using Microsoft.AspNetCore.Mvc;
using ComicBooksLoanAppAPI.Models;
using ComicBooksLoanAppAPI.Services;

namespace ComicBooksLoanAppAPI.Controllers
{
    /// <summary>
    /// API controller for managing user accounts and profiles.
    /// Provides endpoints for user registration, profile management, and discovery.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UsersController> _logger;

        /// <summary>
        /// Initializes a new instance of the UsersController class.
        /// </summary>
        /// <param name="userService">The user service.</param>
        /// <param name="logger">The logger.</param>
        public UsersController(IUserService userService, ILogger<UsersController> logger)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns>A collection of all users.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            try
            {
                var users = await _userService.GetAllUsersAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving all users");
                return StatusCode(500, "An error occurred while retrieving users.");
            }
        }

        /// <summary>
        /// Gets a user by ID.
        /// </summary>
        /// <param name="id">The user ID.</param>
        /// <returns>The user if found.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            try
            {
                var user = await _userService.GetUserAsync(id);
                if (user == null)
                {
                    return NotFound();
                }

                return Ok(user);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid user ID: {id}", id);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving user {id}", id);
                return StatusCode(500, "An error occurred while retrieving the user.");
            }
        }

        /// <summary>
        /// Gets a user by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>The user if found.</returns>
        [HttpGet("username/{username}")]
        public async Task<ActionResult<User>> GetUserByUsername(string username)
        {
            try
            {
                var user = await _userService.GetUserByUsernameAsync(username);
                if (user == null)
                {
                    return NotFound();
                }

                return Ok(user);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid username");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving user by username");
                return StatusCode(500, "An error occurred while retrieving the user.");
            }
        }

        /// <summary>
        /// Registers a new user.
        /// </summary>
        /// <param name="user">The user to register.</param>
        /// <returns>The registered user.</returns>
        [HttpPost("register")]
        public async Task<ActionResult<User>> RegisterUser([FromBody] User user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("User cannot be null.");
                }

                await _userService.RegisterUserAsync(user);
                return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid user registration data");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error registering user");
                return StatusCode(500, "An error occurred while registering the user.");
            }
        }

        /// <summary>
        /// Updates a user's profile.
        /// </summary>
        /// <param name="id">The user ID.</param>
        /// <param name="user">The updated user data.</param>
        /// <returns>No content if successful.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("Invalid user ID.");
                }

                if (user == null)
                {
                    return BadRequest("User cannot be null.");
                }

                user.Id = id;
                await _userService.UpdateUserAsync(user);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid update data for user {id}", id);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating user {id}", id);
                return StatusCode(500, "An error occurred while updating the user.");
            }
        }

        /// <summary>
        /// Gets all verified users.
        /// </summary>
        /// <returns>A collection of verified users.</returns>
        [HttpGet("filter/verified")]
        public async Task<ActionResult<IEnumerable<User>>> GetVerifiedUsers()
        {
            try
            {
                var users = await _userService.GetVerifiedUsersAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving verified users");
                return StatusCode(500, "An error occurred while retrieving verified users.");
            }
        }

        /// <summary>
        /// Gets top-rated members.
        /// </summary>
        /// <param name="count">The number of members to retrieve (default: 10).</param>
        /// <returns>A collection of top-rated members.</returns>
        [HttpGet("filter/toprated")]
        public async Task<ActionResult<IEnumerable<User>>> GetTopRated([FromQuery] int count = 10)
        {
            try
            {
                var users = await _userService.GetTopRatedMembersAsync(count);
                return Ok(users);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid count parameter");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving top-rated members");
                return StatusCode(500, "An error occurred while retrieving top-rated members.");
            }
        }

        /// <summary>
        /// Gets the most active members.
        /// </summary>
        /// <returns>A collection of most active members.</returns>
        [HttpGet("filter/mostactive")]
        public async Task<ActionResult<IEnumerable<User>>> GetMostActive()
        {
            try
            {
                var users = await _userService.GetMostActiveMembersAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving most active members");
                return StatusCode(500, "An error occurred while retrieving most active members.");
            }
        }

        /// <summary>
        /// Increments a user's successful loan count.
        /// </summary>
        /// <param name="id">The user ID.</param>
        /// <returns>No content if successful.</returns>
        [HttpPost("{id}/exchanges/increment")]
        public async Task<IActionResult> IncrementSuccessfulExchanges(int id)
        {
            try
            {
                await _userService.IncrementSuccessfulExchangesAsync(id);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid user ID for increment: {id}", id);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error incrementing exchanges for user {id}", id);
                return StatusCode(500, "An error occurred while updating the user's exchange count.");
            }
        }

        /// <summary>
        /// Updates a user's average rating based on reviews.
        /// </summary>
        /// <param name="id">The user ID.</param>
        /// <returns>No content if successful.</returns>
        [HttpPost("{id}/rating/update")]
        public async Task<IActionResult> UpdateRating(int id)
        {
            try
            {
                await _userService.UpdateUserRatingAsync(id);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid user ID for rating update: {id}", id);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating rating for user {id}", id);
                return StatusCode(500, "An error occurred while updating the user's rating.");
            }
        }

        /// <summary>
        /// Checks if a user has active loans.
        /// </summary>
        /// <param name="id">The user ID.</param>
        /// <returns>True if user has active loans.</returns>
        [HttpGet("{id}/has-active-loans")]
        public async Task<ActionResult<bool>> HasActiveLoans(int id)
        {
            try
            {
                var hasActiveLoans = await _userService.HasActiveLoansAsync(id);
                return Ok(hasActiveLoans);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid user ID: {id}", id);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error checking active loans for user {id}", id);
                return StatusCode(500, "An error occurred while checking active loans.");
            }
        }

        /// <summary>
        /// Deletes a user account.
        /// </summary>
        /// <param name="id">The user ID to delete.</param>
        /// <returns>No content if successful.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                await _userService.DeleteUserAsync(id);
                _logger.LogInformation("User {id} account deleted successfully", id);
                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogWarning(ex, "Cannot delete user {id} - has active loans", id);
                return Conflict(new { message = ex.Message });
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid user ID for deletion: {id}", id);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting user {id}", id);
                return StatusCode(500, "An error occurred while deleting the account.");
            }
        }
    }
}
