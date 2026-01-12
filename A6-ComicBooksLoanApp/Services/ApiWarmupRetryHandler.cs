using System.Net;

namespace A6_ComicBooksLoanApp.Services
{
    /// <summary>
    /// Retries idempotent API requests to tolerate cold-starts (e.g., Render free tier) and transient gateway errors.
    /// </summary>
    public sealed class ApiWarmupRetryHandler : DelegatingHandler
    {
        private static readonly HttpRequestOptionsKey<bool> SkipWarmupOption = new("SkipApiWarmup");

        private static readonly TimeSpan[] RetryDelays =
        [
            TimeSpan.FromMilliseconds(200),
            TimeSpan.FromMilliseconds(500),
            TimeSpan.FromSeconds(1),
            TimeSpan.FromSeconds(2),
            TimeSpan.FromSeconds(4)
        ];

        private readonly ILogger<ApiWarmupRetryHandler> _logger;
        private readonly ApiWarmupState _warmupState;

        public ApiWarmupRetryHandler(ILogger<ApiWarmupRetryHandler> logger, ApiWarmupState warmupState)
        {
            _logger = logger;
            _warmupState = warmupState;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!request.Options.TryGetValue(SkipWarmupOption, out var skipWarmup) || !skipWarmup)
            {
                // Warm up the backend API once per app instance before any real request.
                // This avoids the "blank page" effect when the API is cold (e.g., Render free tier).
                var requestUri = request.RequestUri;
                if (requestUri is not null && requestUri.IsAbsoluteUri)
                {
                    await _warmupState.EnsureWarmedAsync(ct => WarmupAsync(requestUri, ct), cancellationToken);
                }
            }

            // Only retry safe/idempotent methods.
            var canRetry = request.Method == HttpMethod.Get
                || request.Method == HttpMethod.Head
                || request.Method == HttpMethod.Options;

            if (!canRetry)
                return await base.SendAsync(request, cancellationToken);

            for (var attempt = 0; ; attempt++)
            {
                try
                {
                    var response = await base.SendAsync(request, cancellationToken);

                    if (attempt < RetryDelays.Length && IsTransient(response.StatusCode))
                    {
                        var delay = GetRetryDelay(response, attempt);

                        _logger.LogWarning("Transient API response {StatusCode} for {Method} {Uri}. Retrying in {Delay} (attempt {Attempt}/{MaxAttempts})",
                            (int)response.StatusCode,
                            request.Method.Method,
                            request.RequestUri,
                            delay,
                            attempt + 1,
                            RetryDelays.Length);

                        response.Dispose();
                        await Task.Delay(delay, cancellationToken);
                        continue;
                    }

                    return response;
                }
                catch (HttpRequestException ex) when (attempt < RetryDelays.Length)
                {
                    _logger.LogWarning(ex, "Transient API network error for {Method} {Uri}. Retrying in {Delay} (attempt {Attempt}/{MaxAttempts})",
                        request.Method.Method,
                        request.RequestUri,
                        RetryDelays[attempt],
                        attempt + 1,
                        RetryDelays.Length);

                    await Task.Delay(RetryDelays[attempt], cancellationToken);
                }
                catch (TaskCanceledException ex) when (!cancellationToken.IsCancellationRequested && attempt < RetryDelays.Length)
                {
                    _logger.LogWarning(ex, "API timeout for {Method} {Uri}. Retrying in {Delay} (attempt {Attempt}/{MaxAttempts})",
                        request.Method.Method,
                        request.RequestUri,
                        RetryDelays[attempt],
                        attempt + 1,
                        RetryDelays.Length);

                    await Task.Delay(RetryDelays[attempt], cancellationToken);
                }
            }
        }

        private static bool IsTransient(HttpStatusCode statusCode)
            => statusCode is HttpStatusCode.BadGateway
                or HttpStatusCode.ServiceUnavailable
                or HttpStatusCode.GatewayTimeout
                or (HttpStatusCode)429;

        private static TimeSpan GetRetryDelay(HttpResponseMessage response, int attempt)
        {
            if (response.StatusCode == (HttpStatusCode)429)
            {
                // Prefer server-provided Retry-After if present.
                var retryAfter = response.Headers.RetryAfter;
                if (retryAfter?.Delta is TimeSpan delta)
                {
                    // Clamp to something reasonable so we don't stall the UI forever.
                    return delta < TimeSpan.FromSeconds(1) ? TimeSpan.FromSeconds(1)
                        : delta > TimeSpan.FromSeconds(10) ? TimeSpan.FromSeconds(10)
                        : delta;
                }
            }

            return RetryDelays[Math.Clamp(attempt, 0, RetryDelays.Length - 1)];
        }

        private async Task<bool> WarmupAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            // If BaseAddress is missing for some reason, do not block all requests.
            if (InnerHandler is null)
                return true;

            var healthzUri = new Uri(requestUri, "/healthz");

            for (var attempt = 0; attempt <= RetryDelays.Length; attempt++)
            {
                try
                {
                    using var warmupRequest = new HttpRequestMessage(HttpMethod.Get, healthzUri);
                    warmupRequest.Options.Set(SkipWarmupOption, true);

                    using var response = await base.SendAsync(warmupRequest, cancellationToken);
                    if (response.IsSuccessStatusCode)
                        return true;

                    if (attempt < RetryDelays.Length)
                        await Task.Delay(GetRetryDelay(response, attempt), cancellationToken);
                }
                catch (HttpRequestException) when (attempt < RetryDelays.Length)
                {
                    await Task.Delay(RetryDelays[attempt], cancellationToken);
                }
                catch (TaskCanceledException) when (!cancellationToken.IsCancellationRequested && attempt < RetryDelays.Length)
                {
                    await Task.Delay(RetryDelays[attempt], cancellationToken);
                }
            }

            // If warmup never succeeded, still allow normal requests to proceed (they have their own retries).
            return true;
        }
    }
}
