using System.Net.Http.Json;
using System.Text.Json.Nodes;

namespace A6_ComicBooksLoanApp.Services
{
    /// <summary>
    /// Service for communicating with the Comics API backend.
    /// This service acts as a bridge between WebAssembly components and the backend API.
    /// All API communication should go through this server-side service to keep sensitive logic secure.
    /// </summary>
    public class ComicApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ComicApiService> _logger;

        public ComicApiService(HttpClient httpClient, ILogger<ComicApiService> logger)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Gets all available comics from the backend API.
        /// </summary>
        public async Task<List<ComicDto>> GetAvailableComicsAsync()
        {
            try
            {
                var comics = await _httpClient.GetFromJsonAsync<List<ComicDto>>("api/comics/available");
                return comics ?? new();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error retrieving available comics from API");
                return new();
            }
        }

        /// <summary>
        /// Gets a specific comic by ID.
        /// </summary>
        public async Task<ComicDto?> GetComicAsync(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<ComicDto>($"api/comics/{id}");
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, $"Error retrieving comic {id}");
                return null;
            }
        }

        /// <summary>
        /// Gets comics for a specific user.
        /// </summary>
        public async Task<List<ComicDto>> GetUserCollectionAsync(int userId)
        {
            try
            {
                var comics = await _httpClient.GetFromJsonAsync<List<ComicDto>>($"api/comics/user/{userId}");
                return comics ?? new();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, $"Error retrieving user collection for user {userId}");
                return new();
            }
        }

        /// <summary>
        /// Searches comics by title.
        /// </summary>
        public async Task<List<ComicDto>> SearchByTitleAsync(string searchTerm)
        {
            try
            {
                var comics = await _httpClient.GetFromJsonAsync<List<ComicDto>>($"api/comics/search/title?searchTerm={Uri.EscapeDataString(searchTerm)}");
                return comics ?? new();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, $"Error searching comics by title: {searchTerm}");
                return new();
            }
        }

        /// <summary>
        /// Gets comics filtered by era.
        /// </summary>
        public async Task<List<ComicDto>> GetByEraAsync(string era)
        {
            try
            {
                var comics = await _httpClient.GetFromJsonAsync<List<ComicDto>>($"api/comics/filter/era?era={Uri.EscapeDataString(era)}");
                return comics ?? new();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, $"Error retrieving comics by era: {era}");
                return new();
            }
        }

        /// <summary>
        /// Gets comics filtered by condition.
        /// </summary>
        public async Task<List<ComicDto>> GetByConditionAsync(string grade)
        {
            try
            {
                var comics = await _httpClient.GetFromJsonAsync<List<ComicDto>>($"api/comics/filter/condition?grade={Uri.EscapeDataString(grade)}");
                return comics ?? new();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, $"Error retrieving comics by condition: {grade}");
                return new();
            }
        }

        /// <summary>
        /// Gets key issue comics.
        /// </summary>
        public async Task<List<ComicDto>> GetKeyIssuesAsync()
        {
            try
            {
                var comics = await _httpClient.GetFromJsonAsync<List<ComicDto>>("api/comics/filter/keyissues");
                return comics ?? new();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error retrieving key issue comics");
                return new();
            }
        }

        /// <summary>
        /// Gets professionally graded comics.
        /// </summary>
        public async Task<List<ComicDto>> GetProfessionallyGradedAsync()
        {
            try
            {
                var comics = await _httpClient.GetFromJsonAsync<List<ComicDto>>("api/comics/filter/graded");
                return comics ?? new();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error retrieving professionally graded comics");
                return new();
            }
        }

        /// <summary>
        /// Gets comics by character.
        /// </summary>
        public async Task<List<ComicDto>> GetByCharacterAsync(string character)
        {
            try
            {
                var comics = await _httpClient.GetFromJsonAsync<List<ComicDto>>($"api/comics/search/character?character={Uri.EscapeDataString(character)}");
                return comics ?? new();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, $"Error searching comics by character: {character}");
                return new();
            }
        }

        /// <summary>
        /// Gets comics by publisher.
        /// </summary>
        public async Task<List<ComicDto>> GetByPublisherAsync(string publisher)
        {
            try
            {
                var comics = await _httpClient.GetFromJsonAsync<List<ComicDto>>($"api/comics/filter/publisher?publisher={Uri.EscapeDataString(publisher)}");
                return comics ?? new();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, $"Error retrieving comics by publisher: {publisher}");
                return new();
            }
        }

        /// <summary>
        /// Adds a new comic to the collection.
        /// </summary>
        public async Task<(bool Success, string? ErrorMessage)> AddComicAsync(CreateComicDto newComic)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/comics", newComic);

                if (response.IsSuccessStatusCode)
                {
                    return (true, null);
                }

                var responseBody = await response.Content.ReadAsStringAsync();
                var message = ExtractErrorMessage(responseBody);
                if (string.IsNullOrWhiteSpace(message))
                {
                    message = $"Request failed ({(int)response.StatusCode} {response.ReasonPhrase}).";
                }

                _logger.LogWarning("Error adding new comic to the collection: {StatusCode} {Message}", (int)response.StatusCode, message);
                return (false, message);
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error adding new comic to the collection");
                return (false, "Network error while calling the API.");
            }
        }

        private static string? ExtractErrorMessage(string? responseBody)
        {
            if (string.IsNullOrWhiteSpace(responseBody))
            {
                return null;
            }

            // Many endpoints return a plain text error (e.g., "Comic title is required.")
            if (!responseBody.TrimStart().StartsWith("{", StringComparison.Ordinal))
            {
                return responseBody.Trim();
            }

            // Or a ProblemDetails-like JSON payload
            try
            {
                var node = JsonNode.Parse(responseBody);
                if (node == null)
                {
                    return null;
                }

                var errors = node["errors"] as JsonObject;
                if (errors != null && errors.Count > 0)
                {
                    var parts = new List<string>();
                    foreach (var kvp in errors)
                    {
                        if (kvp.Value is JsonArray arr)
                        {
                            foreach (var item in arr)
                            {
                                var msg = item?.GetValue<string>();
                                if (!string.IsNullOrWhiteSpace(msg))
                                {
                                    parts.Add(msg);
                                }
                            }
                        }
                    }

                    if (parts.Count > 0)
                    {
                        return string.Join(" ", parts.Distinct());
                    }
                }

                var detail = node["detail"]?.GetValue<string>();
                if (!string.IsNullOrWhiteSpace(detail))
                {
                    return detail;
                }

                var title = node["title"]?.GetValue<string>();
                return string.IsNullOrWhiteSpace(title) ? null : title;
            }
            catch
            {
                return responseBody.Trim();
            }
        }

        /// <summary>
        /// Searches comics with multiple filters applied (without pagination for backward compatibility).
        /// </summary>
        public async Task<List<ComicDto>> SearchComicsAsync(
            string? searchTerm = null,
            string? era = null,
            string? condition = null,
            string? publisher = null,
            bool keyIssuesOnly = false,
            bool gradedOnly = false)
        {
            try
            {
                // Start with available comics
                var allComics = await GetAvailableComicsAsync();

                // Apply filters
                var filtered = allComics.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    filtered = filtered.Where(c => c.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrWhiteSpace(era))
                {
                    filtered = filtered.Where(c => c.Era.Equals(era, StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrWhiteSpace(condition))
                {
                    filtered = filtered.Where(c => c.ConditionGrade.Equals(condition, StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrWhiteSpace(publisher))
                {
                    filtered = filtered.Where(c => c.Publisher.Contains(publisher, StringComparison.OrdinalIgnoreCase));
                }

                if (keyIssuesOnly)
                {
                    filtered = filtered.Where(c => c.IsKeyIssue);
                }

                if (gradedOnly)
                {
                    filtered = filtered.Where(c => c.IsProfessionallyGraded);
                }

                return filtered.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching comics with filters");
                return new List<ComicDto>();
            }
        }

        /// <summary>
        /// Searches comics with multiple filters applied and pagination support.
        /// Excludes comics owned by the specified user (if provided).
        /// </summary>
        public async Task<PaginatedResult<ComicDto>> SearchComicsPaginatedAsync(
            string? searchTerm = null,
            string? era = null,
            string? condition = null,
            string? publisher = null,
            bool keyIssuesOnly = false,
            bool gradedOnly = false,
            int page = 1,
            int pageSize = 12,
            int? excludeUserId = null)
        {
            try
            {
                // Start with available comics
                var allComics = await GetAvailableComicsAsync();

                // Apply filters
                var filtered = allComics.AsEnumerable();

                // Exclude current user's comics if user ID is provided
                if (excludeUserId.HasValue && excludeUserId.Value > 0)
                {
                    filtered = filtered.Where(c => c.OwnerId != excludeUserId.Value);
                }

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    filtered = filtered.Where(c => c.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrWhiteSpace(era))
                {
                    filtered = filtered.Where(c => c.Era.Equals(era, StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrWhiteSpace(condition))
                {
                    filtered = filtered.Where(c => c.ConditionGrade.Equals(condition, StringComparison.OrdinalIgnoreCase));
                }

                if (!string.IsNullOrWhiteSpace(publisher))
                {
                    filtered = filtered.Where(c => c.Publisher.Contains(publisher, StringComparison.OrdinalIgnoreCase));
                }

                if (keyIssuesOnly)
                {
                    filtered = filtered.Where(c => c.IsKeyIssue);
                }

                if (gradedOnly)
                {
                    filtered = filtered.Where(c => c.IsProfessionallyGraded);
                }

                // Get total count before pagination
                var totalCount = filtered.Count();

                // Apply pagination
                var paginatedComics = filtered
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                return new PaginatedResult<ComicDto>
                {
                    Items = paginatedComics,
                    TotalCount = totalCount,
                    Page = page,
                    PageSize = pageSize,
                    TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize)
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching comics with filters");
                return new PaginatedResult<ComicDto>
                {
                    Items = new List<ComicDto>(),
                    TotalCount = 0,
                    Page = page,
                    PageSize = pageSize,
                    TotalPages = 0
                };
            }
        }
    }

    /// <summary>
    /// Generic paginated result wrapper.
    /// </summary>
    public class PaginatedResult<T>
    {
        public List<T> Items { get; set; } = new();
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage => Page > 1;
        public bool HasNextPage => Page < TotalPages;
    }

    /// <summary>
    /// Data Transfer Object for Comic data.
    /// Used for communication between server and client.
    /// </summary>
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
        public bool IsAvailable { get; set; }
        public bool IsOnLoan { get; set; }
        public DateTime? LoanReturnDate { get; set; }
        public DateTime PublicationDate { get; set; }
        public int OwnerId { get; set; }
        public string OwnerUsername { get; set; } = string.Empty;
        public string? OwnerNotes { get; set; }
        public string? CoverImageUrl { get; set; }
        public bool IsKeyIssue { get; set; }
        public bool IsProfessionallyGraded { get; set; }
    }

    /// <summary>
    /// Data Transfer Object for creating a new comic.
    /// Used when submitting a form to create a comic.
    /// </summary>
    public class CreateComicDto
    {
        public string Title { get; set; } = string.Empty;
        public int IssueNumber { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Publisher { get; set; } = string.Empty;
        public string Characters { get; set; } = string.Empty;
        public string ConditionGrade { get; set; } = string.Empty;
        public string ConditionDescription { get; set; } = string.Empty;
        public string Era { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int OwnerId { get; set; }
        public string? OwnerNotes { get; set; }
        public string? CoverImageUrl { get; set; }
    }
}