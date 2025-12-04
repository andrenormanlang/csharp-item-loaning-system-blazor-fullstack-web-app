using Microsoft.AspNetCore.Mvc;
using ComicBooksExchangeAppAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ComicBooksExchangeAppAPI.Controllers
{
    /// <summary>
    /// Admin controller for development and testing operations.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ComicBooksExchangeDbContext _context;
        private readonly ILogger<AdminController> _logger;

        public AdminController(ComicBooksExchangeDbContext context, ILogger<AdminController> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Resets the database to initial seed state (Development only).
        /// </summary>
        [HttpPost("reset-database")]
        public async Task<IActionResult> ResetDatabase()
        {
            try
            {
                _logger.LogWarning("Starting database reset...");

                // Delete all data in correct order (respect foreign keys)
                _context.Reviews.RemoveRange(_context.Reviews);
                _context.Loans.RemoveRange(_context.Loans);
                _context.LoanRequests.RemoveRange(_context.LoanRequests);
                _context.Comics.RemoveRange(_context.Comics);
                _context.Users.RemoveRange(_context.Users);

                await _context.SaveChangesAsync();

                // Recreate the database with migrations
                await _context.Database.MigrateAsync();

                _logger.LogWarning("Database reset completed successfully");
                return Ok(new { message = "Database has been reset to initial seed state." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error resetting database");
                return StatusCode(500, new { message = "An error occurred while resetting the database." });
            }
        }

        /// <summary>
        /// Gets database statistics (Development only).
        /// </summary>
        [HttpGet("stats")]
        public async Task<IActionResult> GetStats()
        {
            try
            {
                var stats = new
                {
                    users = await _context.Users.CountAsync(),
                    comics = await _context.Comics.CountAsync(),
                    loans = await _context.Loans.CountAsync(),
                    loanRequests = await _context.LoanRequests.CountAsync(),
                    reviews = await _context.Reviews.CountAsync()
                };

                return Ok(stats);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting database stats");
                return StatusCode(500, new { message = "An error occurred while retrieving stats." });
            }
        }
    }
}
