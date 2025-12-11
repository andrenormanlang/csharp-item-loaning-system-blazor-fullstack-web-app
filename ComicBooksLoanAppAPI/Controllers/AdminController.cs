using Microsoft.AspNetCore.Mvc;
using ComicBooksLoanAppAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ComicBooksLoanAppAPI.Controllers
{
    /// <summary>
    /// Admin controller for development and testing operations.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly comicbooksloanDbContext _context;
        private readonly ILogger<AdminController> _logger;

        public AdminController(comicbooksloanDbContext context, ILogger<AdminController> logger)
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

        /// <summary>
        /// Lists users pending approval.
        /// </summary>
        [HttpGet("pending-users")]
        public async Task<IActionResult> GetPendingUsers()
        {
            var users = await _context.Users
                .Where(u => u.ApprovalStatus == Models.ApprovalStatus.Pending)
                .OrderBy(u => u.MemberSince)
                .ToListAsync();
            return Ok(users);
        }

        /// <summary>
        /// Approves a user registration.
        /// </summary>
        [HttpPost("users/{id}/approve")]
        public async Task<IActionResult> ApproveUser([FromRoute] int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user == null) return NotFound();
            user.ApprovalStatus = Models.ApprovalStatus.Approved;
            user.IsVerified = true;
            await _context.SaveChangesAsync();
            return Ok(new { message = "User approved." });
        }

        /// <summary>
        /// Rejects a user registration.
        /// </summary>
        [HttpPost("users/{id}/reject")]
        public async Task<IActionResult> RejectUser([FromRoute] int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user == null) return NotFound();
            user.ApprovalStatus = Models.ApprovalStatus.Rejected;
            await _context.SaveChangesAsync();
            return Ok(new { message = "User rejected." });
        }

        /// <summary>
        /// Lists comics pending approval.
        /// </summary>
        [HttpGet("pending-comics")]
        public async Task<IActionResult> GetPendingComics()
        {
            var comics = await _context.Comics
                .Where(c => c.ApprovalStatus == Models.ApprovalStatus.Pending)
                .Include(c => c.Owner)
                .OrderByDescending(c => c.DateListed)
                .ToListAsync();
            return Ok(comics);
        }

        /// <summary>
        /// Approves a comic submission.
        /// </summary>
        [HttpPost("comics/{id}/approve")]
        public async Task<IActionResult> ApproveComic([FromRoute] int id)
        {
            var comic = await _context.Comics.FirstOrDefaultAsync(c => c.Id == id);
            if (comic == null) return NotFound();
            comic.ApprovalStatus = Models.ApprovalStatus.Approved;
            await _context.SaveChangesAsync();
            return Ok(new { message = "Comic approved." });
        }

        /// <summary>
        /// Rejects a comic submission.
        /// </summary>
        [HttpPost("comics/{id}/reject")]
        public async Task<IActionResult> RejectComic([FromRoute] int id)
        {
            var comic = await _context.Comics.FirstOrDefaultAsync(c => c.Id == id);
            if (comic == null) return NotFound();
            comic.ApprovalStatus = Models.ApprovalStatus.Rejected;
            await _context.SaveChangesAsync();
            return Ok(new { message = "Comic rejected." });
        }
    }
}
