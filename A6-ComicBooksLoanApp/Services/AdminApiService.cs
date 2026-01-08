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

        // Pending Users
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

        public async Task<bool> DeletePendingUserAsync(int userId)
        {
            try { var res = await _httpClient.DeleteAsync($"api/admin/pending-users/{userId}"); return res.IsSuccessStatusCode; }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error deleting pending user"); return false; }
        }

        // All Users Management
        public async Task<List<AdminUserDto>> GetAllUsersAsync()
        {
            try { return await _httpClient.GetFromJsonAsync<List<AdminUserDto>>("api/admin/users") ?? new(); }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error getting all users"); return new(); }
        }

        public async Task<bool> BlockUserAsync(int userId)
        {
            try { var res = await _httpClient.PostAsync($"api/admin/users/{userId}/block", null); return res.IsSuccessStatusCode; }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error blocking user"); return false; }
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            try { var res = await _httpClient.DeleteAsync($"api/admin/users/{userId}"); return res.IsSuccessStatusCode; }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error deleting user"); return false; }
        }

        // Pending Comics
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

        public async Task<bool> DeletePendingComicAsync(int comicId)
        {
            try { var res = await _httpClient.DeleteAsync($"api/admin/pending-comics/{comicId}"); return res.IsSuccessStatusCode; }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error deleting pending comic"); return false; }
        }

        // All Comics Management
        public async Task<List<ComicDto>> GetAllComicsAsync()
        {
            try { return await _httpClient.GetFromJsonAsync<List<ComicDto>>("api/admin/comics") ?? new(); }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error getting all comics"); return new(); }
        }

        public async Task<(bool success, bool? isAvailable)> ToggleComicVisibilityAsync(int comicId)
        {
            try
            {
                var res = await _httpClient.PostAsync($"api/admin/comics/{comicId}/toggle-visibility", null);
                if (res.IsSuccessStatusCode)
                {
                    var result = await res.Content.ReadFromJsonAsync<ToggleVisibilityResponse>();
                    return (true, result?.IsAvailable);
                }
                return (false, null);
            }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error toggling comic visibility"); return (false, null); }
        }

        public async Task<bool> DeleteComicAsync(int comicId)
        {
            try { var res = await _httpClient.DeleteAsync($"api/admin/comics/{comicId}"); return res.IsSuccessStatusCode; }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error deleting comic"); return false; }
        }

        // Announcements
        public async Task<List<AnnouncementDto>> GetActiveAnnouncementsAsync()
        {
            try { return await _httpClient.GetFromJsonAsync<List<AnnouncementDto>>("api/admin/announcements") ?? new(); }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error getting active announcements"); return new(); }
        }

        public async Task<List<AnnouncementDto>> GetAllAnnouncementsAsync()
        {
            try { return await _httpClient.GetFromJsonAsync<List<AnnouncementDto>>("api/admin/announcements/all") ?? new(); }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error getting all announcements"); return new(); }
        }

        public async Task<AnnouncementDto?> CreateAnnouncementAsync(CreateAnnouncementDto dto)
        {
            try
            {
                var res = await _httpClient.PostAsJsonAsync("api/admin/announcements", dto);
                if (res.IsSuccessStatusCode)
                    return await res.Content.ReadFromJsonAsync<AnnouncementDto>();
                return null;
            }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error creating announcement"); return null; }
        }

        public async Task<AnnouncementDto?> UpdateAnnouncementAsync(int announcementId, UpdateAnnouncementDto dto)
        {
            try
            {
                var res = await _httpClient.PutAsJsonAsync($"api/admin/announcements/{announcementId}", dto);
                if (res.IsSuccessStatusCode)
                    return await res.Content.ReadFromJsonAsync<AnnouncementDto>();
                return null;
            }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error updating announcement"); return null; }
        }

        public async Task<bool> DeleteAnnouncementAsync(int announcementId)
        {
            try { var res = await _httpClient.DeleteAsync($"api/admin/announcements/{announcementId}"); return res.IsSuccessStatusCode; }
            catch (HttpRequestException ex) { _logger.LogError(ex, "Error deleting announcement"); return false; }
        }

        private class ToggleVisibilityResponse
        {
            public bool IsAvailable { get; set; }
        }

        public class UserDto
        {
            public int Id { get; set; }
            public string Username { get; set; } = string.Empty;
            public string FullName { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string City { get; set; } = string.Empty;
            public string ZipCode { get; set; } = string.Empty;
            public string ReadingFocus { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public string FavoriteCharacters { get; set; } = string.Empty;
            public string? Biography { get; set; }
            public string? ImageUrl { get; set; }
            public DateTime MemberSince { get; set; }
            public bool IsVerified { get; set; }
        }

        public class ComicDto
        {
            public int Id { get; set; }
            public string Title { get; set; } = string.Empty;
            public int IssueNumber { get; set; }
            public string Publisher { get; set; } = string.Empty;
            public string Characters { get; set; } = string.Empty;
            public string Era { get; set; } = string.Empty;
            public string Genre { get; set; } = string.Empty;
            public string? Description { get; set; }
            public string ConditionGrade { get; set; } = string.Empty;
            public string ConditionDescription { get; set; } = string.Empty;
            public DateTime PublicationDate { get; set; }
            public int OwnerId { get; set; }
            public string? OwnerUsername { get; set; }
            public string? OwnerNotes { get; set; }
            public string? CoverImageUrl { get; set; }
            public bool IsAvailable { get; set; }
            public bool IsOnLoan { get; set; }

            public string OwnerDisplayName => string.IsNullOrWhiteSpace(OwnerUsername)
                ? (OwnerId > 0 ? $"User #{OwnerId}" : "Unknown")
                : OwnerUsername;
        }

        public class AdminUserDto
        {
            public int Id { get; set; }
            public string Username { get; set; } = "";
            public string FullName { get; set; } = "";
            public string Email { get; set; } = "";
            public string City { get; set; } = "";
            public DateTime MemberSince { get; set; }
            public bool IsVerified { get; set; }
            public decimal AverageRating { get; set; }
            public int SuccessfulLoans { get; set; }
            public int ComicsCount { get; set; }
        }
    }

    // DTOs for Announcements
    public class AnnouncementDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public string CreatedByUsername { get; set; } = string.Empty;
    }

    public class CreateAnnouncementDto
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Type { get; set; } = "General";
    }

    public class UpdateAnnouncementDto
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Type { get; set; }
        public bool? IsActive { get; set; }
    }
}
