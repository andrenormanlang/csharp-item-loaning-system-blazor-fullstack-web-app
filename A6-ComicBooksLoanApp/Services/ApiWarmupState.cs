namespace A6_ComicBooksLoanApp.Services
{
    /// <summary>
    /// Coordinates one-time API warmup across all HttpClient requests.
    /// </summary>
    public sealed class ApiWarmupState
    {
        private readonly SemaphoreSlim _gate = new(1, 1);
        private volatile bool _isWarmed;

        public bool IsWarmed => _isWarmed;

        public async Task EnsureWarmedAsync(Func<CancellationToken, Task<bool>> warmupFunc, CancellationToken cancellationToken)
        {
            if (_isWarmed)
                return;

            await _gate.WaitAsync(cancellationToken);
            try
            {
                if (_isWarmed)
                    return;

                _isWarmed = await warmupFunc(cancellationToken);
            }
            finally
            {
                _gate.Release();
            }
        }
    }
}
