using System.Net.Http.Json;
using System.Text.Json;

namespace A6_ComicBooksExchangeApp.Services
{
    /// <summary>
    /// Service for handling user authentication in the Blazor application.
    /// Communicates with the API for login and registration.
    /// </summary>
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<AuthService> _logger;

        public AuthService(HttpClient httpClient, ILogger<AuthService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        /// <summary>
        /// Registers a new user account.
        /// </summary>
        public async Task<(bool Success, string Message)> RegisterAsync(
            string email, 
            string username, 
            string fullName, 
            string password)
        {
            try
            {
                var registerRequest = new
                {
                    email,
                    username,
                    fullName,
                    password
                };

                var response = await _httpClient.PostAsJsonAsync("/api/auth/register", registerRequest);

                if (response.IsSuccessStatusCode)
                {
                    return (true, "Registration successful. Please log in.");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Registration failed: {response.StatusCode} - {errorContent}");
                    return (false, "Registration failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during registration");
                return (false, $"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Logs in a user with email and password.
        /// </summary>
        public async Task<(bool Success, UserData? User, string Message)> LoginAsync(
            string email, 
            string password)
        {
            try
            {
                var loginRequest = new { email, password };
                var response = await _httpClient.PostAsJsonAsync("/api/auth/login", loginRequest);

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();
                    var jsonDoc = JsonDocument.Parse(jsonContent);
                    var root = jsonDoc.RootElement;

                    if (root.TryGetProperty("user", out var userElement))
                    {
                        var userData = new UserData
                        {
                            Id = userElement.GetProperty("id").GetInt32(),
                            Username = userElement.GetProperty("username").GetString() ?? "",
                            Email = userElement.GetProperty("email").GetString() ?? "",
                            FullName = userElement.GetProperty("fullName").GetString() ?? "",
                            ImageUrl = userElement.GetProperty("imageUrl").GetString() ?? ""
                        };
                        return (true, userData, "Login successful");
                    }
                    else
                    {
                        return (false, null, "Invalid response from server");
                    }
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    _logger.LogError($"Login failed: {response.StatusCode} - {errorContent}");
                    return (false, null, "Invalid email or password.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during login");
                return (false, null, $"An error occurred: {ex.Message}");
            }
        }
    }

    public class UserData
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string Email { get; set; } = "";
        public string FullName { get; set; } = "";
        public string ImageUrl { get; set; } = "";
    }
}
