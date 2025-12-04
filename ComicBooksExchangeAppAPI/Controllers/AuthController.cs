using Microsoft.AspNetCore.Mvc;
using ComicBooksExchangeAppAPI.Services;

namespace ComicBooksExchangeAppAPI.Controllers
{
    /// <summary>
    /// API controller for user authentication operations (login, register).
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IAuthenticationService authService, ILogger<AuthController> logger)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Registers a new user account.
        /// </summary>
        [HttpPost("register")]
        public async Task<ActionResult<object>> Register([FromBody] RegisterRequest request)
        {
            try
            {
                if (request == null)
                    return BadRequest("Request cannot be null.");

                var (success, message) = await _authService.RegisterAsync(
                    request.Email,
                    request.Username,
                    request.FullName,
                    request.Password);

                if (!success)
                    return BadRequest(new { message });

                return Ok(new { message = "Registration successful. Please log in." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during registration");
                return StatusCode(500, new { message = "An error occurred during registration." });
            }
        }

        /// <summary>
        /// Authenticates a user and returns user data if successful.
        /// </summary>
        [HttpPost("login")]
        public async Task<ActionResult<object>> Login([FromBody] LoginRequest request)
        {
            try
            {
                if (request == null)
                    return BadRequest("Request cannot be null.");

                var (success, user, message) = await _authService.LoginAsync(request.Email, request.Password);

                if (!success)
                    return Unauthorized(new { message });

                return Ok(new
                {
                    message = "Login successful.",
                    user = new
                    {
                        id = user?.Id,
                        username = user?.Username,
                        email = user?.Email,
                        fullName = user?.FullName,
                        imageUrl = user?.ImageUrl
                    }
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during login");
                return StatusCode(500, new { message = "An error occurred during login." });
            }
        }
    }

    /// <summary>
    /// Model for login requests.
    /// </summary>
    public class LoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    /// <summary>
    /// Model for registration requests.
    /// </summary>
    public class RegisterRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
