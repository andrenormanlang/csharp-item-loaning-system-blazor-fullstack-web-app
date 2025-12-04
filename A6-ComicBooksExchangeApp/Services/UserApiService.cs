using System.Net.Http.Json;

namespace A6_ComicBooksExchangeApp.Services
{
    /// <summary>
    /// Service for communicating with the Users API backend.
    /// This service acts as a bridge between WebAssembly components and the backend API.
    /// All user-related API communication should go through this server-side service.
    /// </summary>
    public class UserApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<UserApiService> _logger;

        public UserApiService(HttpClient httpClient, ILogger<UserApiService> logger)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Gets all users from the backend API.
        /// </summary>
        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            try
            {
                var users = await _httpClient.GetFromJsonAsync<List<UserDto>>("api/users");
                return users ?? new();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error retrieving users from API");
                return new();
            }
        }

        /// <summary>
        /// Gets a specific user by ID.
        /// </summary>
        public async Task<UserDto?> GetUserAsync(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<UserDto>($"api/users/{id}");
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, $"Error retrieving user {id}");
                return null;
            }
        }

        /// <summary>
        /// Gets a user by username.
        /// </summary>
        public async Task<UserDto?> GetUserByUsernameAsync(string username)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<UserDto>($"api/users/username/{Uri.EscapeDataString(username)}");
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, $"Error retrieving user {username}");
                return null;
            }
        }

        /// <summary>
        /// Creates a new user.
        /// </summary>
        public async Task<UserDto?> CreateUserAsync(CreateUserDto userDto)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/users", userDto);
                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning("Failed to create user");
                    return null;
                }
                return await response.Content.ReadFromJsonAsync<UserDto>();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error creating user");
                return null;
            }
        }

        /// <summary>
        /// Updates an existing user.
        /// </summary>
        public async Task<bool> UpdateUserAsync(int id, UserDto userDto)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"api/users/{id}", userDto);
                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning($"Failed to update user {id}");
                    return false;
                }
                return true;
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, $"Error updating user {id}");
                return false;
            }
        }

        /// <summary>
        /// Gets user profile information including statistics.
        /// </summary>
        public async Task<UserProfileDto?> GetUserProfileAsync(int userId)
        {
            try
            {
                var user = await GetUserAsync(userId);
                if (user == null)
                    return null;

                return new UserProfileDto
                {
                    Id = user.Id,
                    Username = user.Username,
                    FullName = user.FullName,
                    Email = user.Email,
                    CollectingFocus = user.CollectingFocus,
                    PreferredEras = user.PreferredEras,
                    FavoriteCharacters = user.FavoriteCharacters,
                    Biography = user.Biography,
                    SuccessfulExchanges = user.SuccessfulExchanges,
                    AverageRating = user.AverageRating,
                    MemberSince = user.MemberSince,
                    IsVerified = user.IsVerified,
                    PreferredExchangeMethod = user.PreferredExchangeMethod,
                    Location = user.Location,
                    ImageUrl = user.ImageUrl
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error retrieving user profile for user {userId}");
                return null;
            }
        }
    }

    /// <summary>
    /// Data Transfer Object for User data.
    /// </summary>
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string CollectingFocus { get; set; } = string.Empty;
        public string PreferredEras { get; set; } = string.Empty;
        public string FavoriteCharacters { get; set; } = string.Empty;
        public string? Biography { get; set; }
        public int SuccessfulExchanges { get; set; }
        public decimal AverageRating { get; set; }
        public DateTime MemberSince { get; set; }
        public bool IsVerified { get; set; }
        public string PreferredExchangeMethod { get; set; } = "Mail";
        public string? Location { get; set; }
        public string? ImageUrl { get; set; }
    }

    /// <summary>
    /// DTO for creating a new user.
    /// </summary>
    public class CreateUserDto
    {
        public string Username { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string CollectingFocus { get; set; } = string.Empty;
        public string PreferredEras { get; set; } = string.Empty;
        public string FavoriteCharacters { get; set; } = string.Empty;
    }

    /// <summary>
    /// DTO for user profile information.
    /// </summary>
    public class UserProfileDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CollectingFocus { get; set; } = string.Empty;
        public string PreferredEras { get; set; } = string.Empty;
        public string FavoriteCharacters { get; set; } = string.Empty;
        public string? Biography { get; set; }
        public int SuccessfulExchanges { get; set; }
        public decimal AverageRating { get; set; }
        public DateTime MemberSince { get; set; }
        public bool IsVerified { get; set; }
        public string PreferredExchangeMethod { get; set; } = "Mail";
        public string? Location { get; set; }
        public string? ImageUrl { get; set; }
    }
}
