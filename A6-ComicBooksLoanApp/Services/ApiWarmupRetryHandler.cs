using System.Net;

namespace A6_ComicBooksLoanApp.Services
{
    /// <summary>
    /// Retries idempotent API requests to tolerate cold-starts (e.g., Render free tier) and transient gateway errors.
    /// </summary>
    public sealed class ApiWarmupRetryHandler : DelegatingHandler
    {
        private static readonly TimeSpan[] RetryDelays =
        [
            TimeSpan.FromMilliseconds(200),
            TimeSpan.FromMilliseconds(500),
            TimeSpan.FromSeconds(1),
            TimeSpan.FromSeconds(2),
            TimeSpan.FromSeconds(4)
        ];

        private readonly ILogger<ApiWarmupRetryHandler> _logger;

        public ApiWarmupRetryHandler(ILogger<ApiWarmupRetryHandler> logger)
        {
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
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
                        _logger.LogWarning("Transient API response {StatusCode} for {Method} {Uri}. Retrying in {Delay} (attempt {Attempt}/{MaxAttempts})",
                            (int)response.StatusCode,
                            request.Method.Method,
                            request.RequestUri,
                            RetryDelays[attempt],
                            attempt + 1,
                            RetryDelays.Length);

                        response.Dispose();
                        await Task.Delay(RetryDelays[attempt], cancellationToken);
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
                or HttpStatusCode.GatewayTimeout;
    }
}
