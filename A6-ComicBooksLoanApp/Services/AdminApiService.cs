using System.Net.Http.Json;

namespace A6_ComicBooksLoanApp.Services
{
    /// <summary>
    /// Service for admin moderation endpoints.
    /// </summary>
    public class AdminApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<AdminApiService> _logger;

        public AdminApiService(HttpClient httpClient, ILogger<AdminApiService> logger)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<UserDto>> GetPendingUsersAsync()
        {
            try { return await _httpClient.GetFromJsonAsync<List<UserDto>>("api/admin/pending-users") ?? new(); }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error getting pending users"); return new(); }
        }

        public async Task<bool> ApproveUserAsync(int userId)
        {
            try { var res = await _httpClient.PostAsync($"api/admin/users/{userId}/approve", null); return res.IsSuccessStatusCode; }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error approving user"); return false; }
        }

        public async Task<bool> RejectUserAsync(int userId)
        {
            try { var res = await _httpClient.PostAsync($"api/admin/users/{userId}/reject", null); return res.IsSuccessStatusCode; }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error rejecting user"); return false; }
        }

        public async Task<List<ComicDto>> GetPendingComicsAsync()
        {
            try { return await _httpClient.GetFromJsonAsync<List<ComicDto>>("api/admin/pending-comics") ?? new(); }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error getting pending comics"); return new(); }
        }

        public async Task<bool> ApproveComicAsync(int comicId)
        {
            try { var res = await _httpClient.PostAsync($"api/admin/comics/{comicId}/approve", null); return res.IsSuccessStatusCode; }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error approving comic"); return false; }
        }

        public async Task<bool> RejectComicAsync(int comicId)
        {
            try { var res = await _httpClient.PostAsync($"api/admin/comics/{comicId}/reject", null); return res.IsSuccessStatusCode; }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error rejecting comic"); return false; }
        }
    }
}
