using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ComicBooksLoanAppAPI.Data;
using ComicBooksLoanAppAPI.Models;

namespace ComicBooksLoanAppAPI.Controllers
{
    /// <summary>
    /// API controller for managing reviews and ratings between users after loan completion.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewsController : ControllerBase
    {
        private readonly comicbooksloanDbContext _context;
        private readonly ILogger<ReviewsController> _logger;

        public ReviewsController(comicbooksloanDbContext context, ILogger<ReviewsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Creates a new review for a completed loan.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<ReviewDto>> CreateReview([FromBody] CreateReviewDto dto)
        {
            try
            {
                _logger.LogInformation("Creating review for loan {loanId} by user {reviewerId}", dto.LoanId, dto.ReviewerId);

                // Validate the loan exists and is returned
                var loan = await _context.Loans
                    .Include(l => l.Borrower)
                    .Include(l => l.Lender)
                    .FirstOrDefaultAsync(l => l.Id == dto.LoanId);

                if (loan == null)
                {
                    _logger.LogWarning("Loan {loanId} not found", dto.LoanId);
                    return NotFound("Loan not found.");
                }

                _logger.LogInformation("Loan {loanId} status: {status}", dto.LoanId, loan.Status);

                if (loan.Status != "Returned")
                {
                    _logger.LogWarning("Loan {loanId} is not returned, status: {status}", dto.LoanId, loan.Status);
                    return BadRequest("Can only review completed loans.");
                }

                // Determine who is being reviewed
                int reviewedUserId;
                if (loan.BorrowerId == dto.ReviewerId)
                {
                    // Borrower reviewing the lender
                    reviewedUserId = loan.LenderId;
                    _logger.LogInformation("Borrower {borrowerId} reviewing lender {lenderId}", dto.ReviewerId, reviewedUserId);
                }
                else if (loan.LenderId == dto.ReviewerId)
                {
                    // Lender reviewing the borrower
                    reviewedUserId = loan.BorrowerId;
                    _logger.LogInformation("Lender {lenderId} reviewing borrower {borrowerId}", dto.ReviewerId, reviewedUserId);
                }
                else
                {
                    _logger.LogWarning("User {userId} is not part of loan {loanId}", dto.ReviewerId, dto.LoanId);
                    return BadRequest("You are not part of this loan.");
                }

                // Check if review already exists
                var existingReview = await _context.Reviews
                    .FirstOrDefaultAsync(r => r.LoanId == dto.LoanId && r.ReviewerId == dto.ReviewerId);

                if (existingReview != null)
                {
                    _logger.LogWarning("User {userId} has already reviewed loan {loanId}", dto.ReviewerId, dto.LoanId);
                    return BadRequest("You have already reviewed this loan.");
                }

                // Create the review
                var review = new Review
                {
                    ReviewerId = dto.ReviewerId,
                    ReviewedUserId = reviewedUserId,
                    LoanId = dto.LoanId,
                    Rating = dto.Rating,
                    Comment = dto.Comment,
                    ConditionAsDescribed = dto.ConditionAsDescribed,
                    CommunicationGood = dto.CommunicationGood,
                    MeetupExperience = dto.MeetupExperience,
                    DateSubmitted = DateTime.UtcNow
                };

                _context.Reviews.Add(review);

                // Update the reviewed user's average rating
                var reviewedUser = await _context.Users.FindAsync(reviewedUserId);
                if (reviewedUser != null)
                {
                    var allReviews = await _context.Reviews
                        .Where(r => r.ReviewedUserId == reviewedUserId)
                        .ToListAsync();
                    
                    var totalReviews = allReviews.Count + 1; // Including the new review
                    var totalRating = allReviews.Sum(r => r.Rating) + dto.Rating;
                    reviewedUser.AverageRating = (decimal)totalRating / totalReviews;
                    
                    _logger.LogInformation("Updated user {userId} average rating to {rating}", reviewedUserId, reviewedUser.AverageRating);
                }

                await _context.SaveChangesAsync();

                _logger.LogInformation("Review created successfully: {reviewId} for loan {loanId}", review.Id, dto.LoanId);

                return CreatedAtAction(nameof(GetReview), new { id = review.Id }, new ReviewDto
                {
                    Id = review.Id,
                    ReviewerId = review.ReviewerId,
                    ReviewedUserId = review.ReviewedUserId,
                    LoanId = review.LoanId,
                    Rating = review.Rating,
                    Comment = review.Comment,
                    DateSubmitted = review.DateSubmitted
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating review for loan {loanId}: {message}", dto.LoanId, ex.Message);
                return StatusCode(500, "An error occurred while creating the review.");
            }
        }

        /// <summary>
        /// Gets a review by ID.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<ReviewDto>> GetReview(int id)
        {
            try
            {
                var review = await _context.Reviews
                    .Include(r => r.Reviewer)
                    .Include(r => r.ReviewedUser)
                    .FirstOrDefaultAsync(r => r.Id == id);

                if (review == null)
                {
                    return NotFound();
                }

                return Ok(new ReviewDto
                {
                    Id = review.Id,
                    ReviewerId = review.ReviewerId,
                    ReviewerUsername = review.Reviewer?.Username ?? "",
                    ReviewedUserId = review.ReviewedUserId,
                    ReviewedUsername = review.ReviewedUser?.Username ?? "",
                    LoanId = review.LoanId,
                    Rating = review.Rating,
                    Comment = review.Comment,
                    ConditionAsDescribed = review.ConditionAsDescribed,
                    CommunicationGood = review.CommunicationGood,
                    MeetupExperience = review.MeetupExperience,
                    DateSubmitted = review.DateSubmitted
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting review {id}", id);
                return StatusCode(500, "An error occurred while retrieving the review.");
            }
        }

        /// <summary>
        /// Gets all reviews for a specific user.
        /// </summary>
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<ReviewDto>>> GetUserReviews(int userId)
        {
            try
            {
                var reviews = await _context.Reviews
                    .Include(r => r.Reviewer)
                    .Include(r => r.Loan)
                    .ThenInclude(l => l.Comic)
                    .Where(r => r.ReviewedUserId == userId)
                    .OrderByDescending(r => r.DateSubmitted)
                    .Select(r => new ReviewDto
                    {
                        Id = r.Id,
                        ReviewerId = r.ReviewerId,
                        ReviewerUsername = r.Reviewer != null ? r.Reviewer.Username : "",
                        ReviewedUserId = r.ReviewedUserId,
                        LoanId = r.LoanId,
                        Rating = r.Rating,
                        Comment = r.Comment,
                        ConditionAsDescribed = r.ConditionAsDescribed,
                        CommunicationGood = r.CommunicationGood,
                        MeetupExperience = r.MeetupExperience,
                        DateSubmitted = r.DateSubmitted,
                        ComicTitle = r.Loan != null && r.Loan.Comic != null ? r.Loan.Comic.Title : ""
                    })
                    .ToListAsync();

                return Ok(reviews);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting reviews for user {userId}", userId);
                return StatusCode(500, "An error occurred while retrieving reviews.");
            }
        }

        /// <summary>
        /// Checks if a user has already reviewed a specific loan.
        /// </summary>
        [HttpGet("loan/{loanId}/user/{userId}/exists")]
        public async Task<ActionResult<bool>> HasUserReviewedLoan(int loanId, int userId)
        {
            try
            {
                var exists = await _context.Reviews
                    .AnyAsync(r => r.LoanId == loanId && r.ReviewerId == userId);

                return Ok(exists);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error checking review existence");
                return StatusCode(500, "An error occurred.");
            }
        }
    }

    // DTOs for Review operations
    public class CreateReviewDto
    {
        public int ReviewerId { get; set; }
        public int LoanId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public bool ConditionAsDescribed { get; set; }
        public bool CommunicationGood { get; set; }
        public bool MeetupExperience { get; set; }
    }

    public class ReviewDto
    {
        public int Id { get; set; }
        public int ReviewerId { get; set; }
        public string ReviewerUsername { get; set; } = "";
        public int ReviewedUserId { get; set; }
        public string ReviewedUsername { get; set; } = "";
        public int? LoanId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public bool ConditionAsDescribed { get; set; }
        public bool CommunicationGood { get; set; }
        public bool MeetupExperience { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string ComicTitle { get; set; } = "";
    }
}
