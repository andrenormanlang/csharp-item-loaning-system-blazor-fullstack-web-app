using System.Net.Http.Json;
using System.Text.Json;
using System.Linq;

namespace A6_ComicBooksLoanApp.Services
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
            string password,
            string city,
            string zipCode,
            string readingFocus,
            string description,
            string favoriteCharacters,
            string? biography,
            string? imageUrl)
        {
            try
            {
                var registerRequest = new
                {
                    email,
                    username,
                    fullName,
                    password,
                    city,
                    zipCode,
                    readingFocus,
                    description,
                    favoriteCharacters,
                    biography,
                    imageUrl
                };

                var response = await _httpClient.PostAsJsonAsync("/api/auth/register", registerRequest);

                if (response.IsSuccessStatusCode)
                {
                    return (true, "Registration successful. Please log in.");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();

                    // Try to extract a clear API error message
                    string userMessage = "Registration failed. Please try again.";
                    try
                    {
                        using var doc = JsonDocument.Parse(errorContent);
                        var root = doc.RootElement;
                        if (root.ValueKind == JsonValueKind.Object)
                        {
                            if (root.TryGetProperty("message", out var msgEl) && msgEl.ValueKind == JsonValueKind.String)
                                userMessage = msgEl.GetString() ?? userMessage;
                            // Handle model state style errors (first error string)
                            else if (root.EnumerateObject().FirstOrDefault().Value.ValueKind == JsonValueKind.Array)
                            {
                                var first = root.EnumerateObject().FirstOrDefault().Value.EnumerateArray().FirstOrDefault();
                                if (first.ValueKind == JsonValueKind.String)
                                    userMessage = first.GetString() ?? userMessage;
                            }
                        }
                    }
                    catch (Exception parseEx)
                    {
                        _logger.LogWarning(parseEx, "Failed to parse registration error response.");
                    }

                    _logger.LogError($"Registration failed: {response.StatusCode} - {errorContent}");
                    return (false, userMessage);
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

                    // If API uses a DTO with success flag
                    if (root.TryGetProperty("success", out var successEl) && successEl.ValueKind == JsonValueKind.False)
                    {
                        var msg = root.TryGetProperty("message", out var msgEl) && msgEl.ValueKind == JsonValueKind.String ? msgEl.GetString() : "Login failed";
                        _logger.LogWarning("Login unsuccessful: {Message}", msg);
                        return (false, null, msg);
                    }

                    // Extract user and role safely
                    JsonElement userEl = root;
                    if (root.TryGetProperty("user", out var uEl) && uEl.ValueKind == JsonValueKind.Object)
                        userEl = uEl;

                    int id = 0;
                    if (userEl.TryGetProperty("id", out var idEl) && idEl.ValueKind == JsonValueKind.Number)
                        id = idEl.GetInt32();

                    string? username = null;
                    if (userEl.TryGetProperty("username", out var unEl) && unEl.ValueKind == JsonValueKind.String)
                        username = unEl.GetString();

                    string? email_ret = null;
                    if (userEl.TryGetProperty("email", out var emailEl) && emailEl.ValueKind == JsonValueKind.String)
                        email_ret = emailEl.GetString();

                    string? fullName = null;
                    if (userEl.TryGetProperty("fullName", out var fnEl) && fnEl.ValueKind == JsonValueKind.String)
                        fullName = fnEl.GetString();

                    string? imageUrl = null;
                    if (userEl.TryGetProperty("imageUrl", out var imgEl) && imgEl.ValueKind == JsonValueKind.String)
                        imageUrl = imgEl.GetString();

                    string? role = null;
                    if (userEl.TryGetProperty("role", out var roleEl) && roleEl.ValueKind == JsonValueKind.String)
                        role = roleEl.GetString();

                    _logger.LogInformation("User logged in. Id: {Id}, Username: {Username}, Role: {Role}",
                        id, username ?? "unknown", role ?? "unknown");

                    return (true, new UserData
                    {
                        Id = id,
                        Username = username ?? "",
                        Email = email_ret ?? "",
                        FullName = fullName ?? "",
                        ImageUrl = imageUrl ?? "",
                        Role = role ?? ""
                    }, "Login successful");
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
        public string Role { get; set; } = "";
    }
}
