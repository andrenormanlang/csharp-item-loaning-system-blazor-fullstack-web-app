using Microsoft.AspNetCore.Mvc;
using ComicBooksLoanAppAPI.Data;
using Microsoft.EntityFrameworkCore;
using ComicBooksLoanAppAPI.Models.DTOs;

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

        /// <summary>
        /// Gets all approved users for management.
        /// </summary>
        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _context.Users
                .Where(u => u.ApprovalStatus == Models.ApprovalStatus.Approved && u.Role != "Admin")
                .Include(u => u.Comics)
                .OrderBy(u => u.Username)
                .Select(u => new
                {
                    u.Id,
                    u.Username,
                    u.FullName,
                    u.Email,
                    u.City,
                    u.MemberSince,
                    u.IsVerified,
                    u.AverageRating,
                    u.SuccessfulLoans,
                    ComicsCount = u.Comics.Count
                })
                .ToListAsync();
            return Ok(users);
        }

        /// <summary>
        /// Blocks a user account.
        /// </summary>
        [HttpPost("users/{id}/block")]
        public async Task<IActionResult> BlockUser([FromRoute] int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user == null) return NotFound();
            if (user.Role == "Admin") return BadRequest(new { message = "Cannot block admin users." });

            user.ApprovalStatus = Models.ApprovalStatus.Rejected;
            user.IsVerified = false;
            await _context.SaveChangesAsync();
            return Ok(new { message = "User blocked successfully." });
        }

        /// <summary>
        /// Deletes a user account and all related data.
        /// </summary>
        [HttpDelete("users/{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            var user = await _context.Users
                .Include(u => u.Comics)
                .Include(u => u.LoansAsLender)
                .Include(u => u.LoansAsBorrower)
                .Include(u => u.ReviewsReceived)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null) return NotFound();
            if (user.Role == "Admin") return BadRequest(new { message = "Cannot delete admin users." });

            // Check for active loans
            var activeLoans = user.LoansAsLender.Any(l => l.Status == "Active" || l.Status == "Overdue") ||
                            user.LoansAsBorrower.Any(l => l.Status == "Active" || l.Status == "Overdue");

            if (activeLoans)
                return BadRequest(new { message = "Cannot delete user with active loans. Please resolve all loans first." });

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return Ok(new { message = "User deleted successfully." });
        }

        /// <summary>
        /// Gets all approved comics for management.
        /// </summary>
        [HttpGet("comics")]
        public async Task<IActionResult> GetAllComics()
        {
            var comics = await _context.Comics
                .Where(c => c.ApprovalStatus == Models.ApprovalStatus.Approved)
                .Include(c => c.Owner)
                .OrderByDescending(c => c.DateListed)
                .ToListAsync();
            return Ok(comics);
        }

        /// <summary>
        /// Toggles comic visibility (IsAvailable flag).
        /// </summary>
        [HttpPost("comics/{id}/toggle-visibility")]
        public async Task<IActionResult> ToggleComicVisibility([FromRoute] int id)
        {
            var comic = await _context.Comics.FirstOrDefaultAsync(c => c.Id == id);
            if (comic == null) return NotFound();

            // Check if comic is currently on loan
            if (comic.IsOnLoan)
                return BadRequest(new { message = "Cannot toggle visibility for comics currently on loan." });

            comic.IsAvailable = !comic.IsAvailable;
            await _context.SaveChangesAsync();

            return Ok(new { message = $"Comic visibility toggled. Now {(comic.IsAvailable ? "visible" : "hidden")}.", isAvailable = comic.IsAvailable });
        }

        /// <summary>
        /// Deletes a comic from the system.
        /// </summary>
        [HttpDelete("comics/{id}")]
        public async Task<IActionResult> DeleteComic([FromRoute] int id)
        {
            var comic = await _context.Comics.FirstOrDefaultAsync(c => c.Id == id);

            if (comic == null) return NotFound();

            // Check for active loans using IsOnLoan property
            if (comic.IsOnLoan)
                return BadRequest(new { message = "Cannot delete comic that is currently on loan." });

            // Also check if there are any active/overdue loans for this comic in the Loans table
            var hasActiveLoans = await _context.Loans
                .AnyAsync(l => l.ComicId == id && (l.Status == "Active" || l.Status == "Overdue"));

            if (hasActiveLoans)
                return BadRequest(new { message = "Cannot delete comic with active loans." });

            _context.Comics.Remove(comic);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Comic deleted successfully." });
        }

        // ============================================================
        // ANNOUNCEMENTS MANAGEMENT
        // ============================================================

        /// <summary>
        /// Gets all active announcements (public endpoint).
        /// </summary>
        [HttpGet("announcements")]
        public async Task<IActionResult> GetActiveAnnouncements()
        {
            var announcements = await _context.Announcements
                .Where(a => a.IsActive)
                .Include(a => a.CreatedBy)
                .OrderByDescending(a => a.CreatedAt)
                .Select(a => new AnnouncementDto
                {
                    Id = a.Id,
                    Title = a.Title,
                    Content = a.Content,
                    Type = a.Type.ToString(),
                    CreatedAt = a.CreatedAt,
                    UpdatedAt = a.UpdatedAt,
                    IsActive = a.IsActive,
                    CreatedByUsername = a.CreatedBy != null ? a.CreatedBy.Username : "Admin"
                })
                .ToListAsync();

            return Ok(announcements);
        }

        /// <summary>
        /// Gets all announcements including inactive ones (admin only).
        /// </summary>
        [HttpGet("announcements/all")]
        public async Task<IActionResult> GetAllAnnouncements()
        {
            var announcements = await _context.Announcements
                .Include(a => a.CreatedBy)
                .OrderByDescending(a => a.CreatedAt)
                .Select(a => new AnnouncementDto
                {
                    Id = a.Id,
                    Title = a.Title,
                    Content = a.Content,
                    Type = a.Type.ToString(),
                    CreatedAt = a.CreatedAt,
                    UpdatedAt = a.UpdatedAt,
                    IsActive = a.IsActive,
                    CreatedByUsername = a.CreatedBy != null ? a.CreatedBy.Username : "Admin"
                })
                .ToListAsync();

            return Ok(announcements);
        }

        /// <summary>
        /// Creates a new announcement (admin only).
        /// </summary>
        [HttpPost("announcements")]
        public async Task<IActionResult> CreateAnnouncement([FromBody] CreateAnnouncementDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Title) || string.IsNullOrWhiteSpace(dto.Content))
                return BadRequest(new { message = "Title and content are required." });

            // Parse the type
            if (!Enum.TryParse<Models.AnnouncementType>(dto.Type, true, out var announcementType))
                announcementType = Models.AnnouncementType.General;

            // For now, use admin user (ID = 6 from seed data)
            // In production, this would come from the authenticated user
            var adminUser = await _context.Users.FirstOrDefaultAsync(u => u.Role == "Admin");
            if (adminUser == null)
                return BadRequest(new { message = "No admin user found." });

            var announcement = new Models.Announcement
            {
                Title = dto.Title,
                Content = dto.Content,
                Type = announcementType,
                CreatedByUserId = adminUser.Id,
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            };

            _context.Announcements.Add(announcement);
            await _context.SaveChangesAsync();

            var result = new AnnouncementDto
            {
                Id = announcement.Id,
                Title = announcement.Title,
                Content = announcement.Content,
                Type = announcement.Type.ToString(),
                CreatedAt = announcement.CreatedAt,
                UpdatedAt = announcement.UpdatedAt,
                IsActive = announcement.IsActive,
                CreatedByUsername = adminUser.Username
            };

            return CreatedAtAction(nameof(GetActiveAnnouncements), new { id = announcement.Id }, result);
        }

        /// <summary>
        /// Updates an existing announcement (admin only).
        /// </summary>
        [HttpPut("announcements/{id}")]
        public async Task<IActionResult> UpdateAnnouncement([FromRoute] int id, [FromBody] UpdateAnnouncementDto dto)
        {
            var announcement = await _context.Announcements
                .Include(a => a.CreatedBy)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (announcement == null)
                return NotFound(new { message = "Announcement not found." });

            if (!string.IsNullOrWhiteSpace(dto.Title))
                announcement.Title = dto.Title;

            if (!string.IsNullOrWhiteSpace(dto.Content))
                announcement.Content = dto.Content;

            if (!string.IsNullOrWhiteSpace(dto.Type) && Enum.TryParse<Models.AnnouncementType>(dto.Type, true, out var announcementType))
                announcement.Type = announcementType;

            if (dto.IsActive.HasValue)
                announcement.IsActive = dto.IsActive.Value;

            announcement.UpdatedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            var result = new AnnouncementDto
            {
                Id = announcement.Id,
                Title = announcement.Title,
                Content = announcement.Content,
                Type = announcement.Type.ToString(),
                CreatedAt = announcement.CreatedAt,
                UpdatedAt = announcement.UpdatedAt,
                IsActive = announcement.IsActive,
                CreatedByUsername = announcement.CreatedBy?.Username ?? "Admin"
            };

            return Ok(result);
        }

        /// <summary>
        /// Deletes an announcement (admin only).
        /// </summary>
        [HttpDelete("announcements/{id}")]
        public async Task<IActionResult> DeleteAnnouncement([FromRoute] int id)
        {
            var announcement = await _context.Announcements.FirstOrDefaultAsync(a => a.Id == id);

            if (announcement == null)
                return NotFound(new { message = "Announcement not found." });

            _context.Announcements.Remove(announcement);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Announcement deleted successfully." });
        }
    }
}
