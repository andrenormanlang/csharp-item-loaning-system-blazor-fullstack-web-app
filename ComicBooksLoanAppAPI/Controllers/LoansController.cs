using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ComicBooksLoanAppAPI.Data;
using ComicBooksLoanAppAPI.Models;

namespace ComicBooksLoanAppAPI.Controllers
{
    /// <summary>
    /// API controller for managing loan requests and active loans.
    /// Simplified for one-way lending (no two-way exchanges).
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class LoansController : ControllerBase
    {
        private readonly comicbooksloanDbContext _context;
        private readonly ILogger<LoansController> _logger;

        public LoansController(comicbooksloanDbContext context, ILogger<LoansController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Gets all loan requests for a user (as requester or owner).
        /// </summary>
        [HttpGet("requests/user/{userId}")]
        public async Task<ActionResult<IEnumerable<LoanRequestDto>>> GetUserLoanRequests(int userId)
        {
            try
            {
                var requests = await _context.LoanRequests
                    .Include(r => r.Requester)
                    .Include(r => r.Owner)
                    .Include(r => r.RequestedComic)
                    .Where(r => r.RequesterId == userId || r.OwnerId == userId)
                    .OrderByDescending(r => r.DateCreated)
                    .Select(r => new LoanRequestDto
                    {
                        Id = r.Id,
                        RequesterId = r.RequesterId,
                        RequesterUsername = r.Requester != null ? r.Requester.Username : "",
                        OwnerId = r.OwnerId,
                        OwnerUsername = r.Owner != null ? r.Owner.Username : "",
                        RequestedComicId = r.RequestedComicId,
                        RequestedComicTitle = r.RequestedComic != null ? r.RequestedComic.Title : "",
                        Status = r.Status,
                        RequestedLoanDurationDays = r.RequestedLoanDurationDays,
                        Message = r.Message,
                        DateCreated = r.DateCreated,
                        DateResponded = r.DateResponded,
                        ResponseMessage = r.ResponseMessage
                    })
                    .ToListAsync();

                return Ok(requests);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting loan requests for user {userId}", userId);
                return StatusCode(500, "An error occurred while retrieving loan requests.");
            }
        }

        /// <summary>
        /// Gets the count of pending loan requests for a user (as owner).
        /// </summary>
        [HttpGet("requests/pending-count/{userId}")]
        public async Task<ActionResult<int>> GetPendingLoanRequestsCount(int userId)
        {
            try
            {
                var count = await _context.LoanRequests
                    .Where(r => r.OwnerId == userId && r.Status == "Pending")
                    .CountAsync();
                
                return Ok(count);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting pending loan requests count for user {userId}", userId);
                return StatusCode(500, "An error occurred while retrieving the pending requests count.");
            }
        }

        /// <summary>
        /// Gets all active loans for a user (as borrower or lender).
        /// </summary>
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<LoanDto>>> GetUserLoans(int userId)
        {
            try
            {
                var loans = await _context.Loans
                    .Include(l => l.Borrower)
                    .Include(l => l.Lender)
                    .Include(l => l.Comic)
                    .Where(l => l.BorrowerId == userId || l.LenderId == userId)
                    .OrderByDescending(l => l.LoanStartDate)
                    .Select(l => new LoanDto
                    {
                        Id = l.Id,
                        BorrowerId = l.BorrowerId,
                        BorrowerUsername = l.Borrower != null ? l.Borrower.Username : "",
                        LenderId = l.LenderId,
                        LenderUsername = l.Lender != null ? l.Lender.Username : "",
                        ComicId = l.ComicId,
                        ComicTitle = l.Comic != null ? l.Comic.Title : "",
                        ComicIssue = l.Comic != null ? l.Comic.IssueNumber : 0,
                        Status = l.Status,
                        LoanStartDate = l.LoanStartDate ?? DateTime.MinValue,
                        LoanEndDate = l.LoanEndDate,
                        ActualReturnDate = l.ActualReturnDate,
                        MeetupDateTime = l.MeetupDateTime,
                        MeetupLocation = l.MeetupLocation,
                        ReturnMeetupDateTime = l.ReturnMeetupDateTime,
                        ReturnMeetupLocation = l.ReturnMeetupLocation,
                        BorrowerReceivedComic = l.BorrowerReceivedComic,
                        LenderConfirmedReturn = l.LenderConfirmedReturn
                    })
                    .ToListAsync();

                return Ok(loans);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting loans for user {userId}", userId);
                return StatusCode(500, "An error occurred while retrieving loans.");
            }
        }

        /// <summary>
        /// Creates a new loan request.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<LoanRequestDto>> CreateLoanRequest([FromBody] CreateLoanRequestDto dto)
        {
            try
            {
                // Validate the comic exists and is available
                var comic = await _context.Comics.FindAsync(dto.ComicId);
                if (comic == null)
                {
                    return NotFound("Comic not found.");
                }

                if (!comic.IsAvailable)
                {
                    return BadRequest("Comic is not available for loan.");
                }

                if (comic.OwnerId == dto.BorrowerId)
                {
                    return BadRequest("You cannot borrow your own comic.");
                }

                // Check if user already has a pending request for this comic
                var existingRequest = await _context.LoanRequests
                    .FirstOrDefaultAsync(r => r.RequesterId == dto.BorrowerId
                        && r.RequestedComicId == dto.ComicId
                        && r.Status == "Pending");

                if (existingRequest != null)
                {
                    return BadRequest("You already have a pending request for this comic.");
                }

                // Create the loan request
                var loanRequest = new LoanRequest
                {
                    RequesterId = dto.BorrowerId,
                    OwnerId = comic.OwnerId,
                    RequestedComicId = dto.ComicId,
                    Message = dto.Message,
                    RequestedLoanDurationDays = (dto.RequestedReturnDate - DateTime.Today).Days,
                    Status = "Pending",
                    DateCreated = DateTime.UtcNow
                };

                _context.LoanRequests.Add(loanRequest);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Loan request created: {requestId}", loanRequest.Id);

                return CreatedAtAction(nameof(GetLoanRequest), new { id = loanRequest.Id }, new LoanRequestDto
                {
                    Id = loanRequest.Id,
                    RequesterId = loanRequest.RequesterId,
                    OwnerId = loanRequest.OwnerId,
                    RequestedComicId = loanRequest.RequestedComicId,
                    Status = loanRequest.Status,
                    DateCreated = loanRequest.DateCreated
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating loan request");
                return StatusCode(500, "An error occurred while creating the loan request.");
            }
        }

        /// <summary>
        /// Gets a loan request by ID.
        /// </summary>
        [HttpGet("requests/{id}")]
        public async Task<ActionResult<LoanRequestDto>> GetLoanRequest(int id)
        {
            var request = await _context.LoanRequests
                .Include(r => r.Requester)
                .Include(r => r.Owner)
                .Include(r => r.RequestedComic)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (request == null)
            {
                return NotFound();
            }

            return Ok(new LoanRequestDto
            {
                Id = request.Id,
                RequesterId = request.RequesterId,
                RequesterUsername = request.Requester?.Username ?? "",
                OwnerId = request.OwnerId,
                OwnerUsername = request.Owner?.Username ?? "",
                RequestedComicId = request.RequestedComicId,
                RequestedComicTitle = request.RequestedComic?.Title ?? "",
                Status = request.Status,
                Message = request.Message,
                DateCreated = request.DateCreated
            });
        }

        /// <summary>
        /// Accepts a loan request.
        /// </summary>
        [HttpPost("requests/{id}/accept")]
        public async Task<IActionResult> AcceptLoanRequest(int id)
        {
            try
            {
                var request = await _context.LoanRequests
                    .Include(r => r.RequestedComic)
                    .FirstOrDefaultAsync(r => r.Id == id);

                if (request == null)
                {
                    return NotFound();
                }

                if (request.Status != "Pending")
                {
                    return BadRequest("Request is no longer pending.");
                }

                // Update request status
                request.Status = "Accepted";
                request.DateResponded = DateTime.UtcNow;

                // Create the loan
                var loan = new Loan
                {
                    BorrowerId = request.RequesterId,
                    LenderId = request.OwnerId,
                    ComicId = request.RequestedComicId,
                    Status = "Active",
                    DateCreated = DateTime.UtcNow,
                    LoanStartDate = DateTime.UtcNow,
                    LoanEndDate = DateTime.UtcNow.AddDays(request.RequestedLoanDurationDays),
                    LoanDurationDays = request.RequestedLoanDurationDays,
                    LoanRequestId = request.Id
                };

                _context.Loans.Add(loan);
                // Save first to generate Loan.Id
                await _context.SaveChangesAsync();

                // Mark the comic as on loan and link to the loan
                if (request.RequestedComic != null)
                {
                    request.RequestedComic.IsAvailable = false;
                    request.RequestedComic.IsOnLoan = true;
                    request.RequestedComic.CurrentLoanId = loan.Id;
                    request.RequestedComic.LoanReturnDate = loan.LoanEndDate;
                }

                await _context.SaveChangesAsync();

                return Ok(new { message = "Loan request accepted", loanId = loan.Id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error accepting loan request {id}", id);
                return StatusCode(500, "An error occurred while accepting the loan request.");
            }
        }

        /// <summary>
        /// Declines a loan request.
        /// </summary>
        [HttpPost("requests/{id}/decline")]
        public async Task<IActionResult> DeclineLoanRequest(int id, [FromBody] DeclineRequestDto? dto = null)
        {
            try
            {
                var request = await _context.LoanRequests.FindAsync(id);

                if (request == null)
                {
                    return NotFound();
                }

                if (request.Status != "Pending")
                {
                    return BadRequest("Request is no longer pending.");
                }

                request.Status = "Declined";
                request.DateResponded = DateTime.UtcNow;
                request.ResponseMessage = dto?.Message;

                await _context.SaveChangesAsync();

                return Ok(new { message = "Loan request declined" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error declining loan request {id}", id);
                return StatusCode(500, "An error occurred while declining the loan request.");
            }
        }

        /// <summary>
        /// Marks a loan as returned.
        /// </summary>
        [HttpPost("{id}/return")]
        public async Task<IActionResult> ReturnLoan(int id)
        {
            try
            {
                var loan = await _context.Loans
                    .Include(l => l.Comic)
                    .FirstOrDefaultAsync(l => l.Id == id);

                if (loan == null)
                {
                    return NotFound();
                }

                if (loan.Status != "Active")
                {
                    return BadRequest("Loan is not active.");
                }

                loan.Status = "Returned";
                loan.ActualReturnDate = DateTime.UtcNow;

                // Mark the comic as available again and clear loan linkage
                if (loan.Comic != null)
                {
                    loan.Comic.IsAvailable = true;
                    loan.Comic.IsOnLoan = false;
                    loan.Comic.CurrentLoanId = null;
                    loan.Comic.LoanReturnDate = null;
                }

                await _context.SaveChangesAsync();

                return Ok(new { message = "Loan marked as returned" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error returning loan {id}", id);
                return StatusCode(500, "An error occurred while returning the loan.");
            }
        }

        /// <summary>
        /// Arranges the initial meetup for a loan.
        /// </summary>
        [HttpPost("{id}/arrange-meetup")]
        public async Task<IActionResult> ArrangeMeetup(int id, [FromBody] ArrangeMeetupDto dto)
        {
            try
            {
                var loan = await _context.Loans.FindAsync(id);

                if (loan == null)
                {
                    return NotFound();
                }

                if (loan.Status != "Active")
                {
                    return BadRequest("Loan is not active.");
                }

                loan.MeetupLocation = dto.MeetupLocation;
                loan.MeetupDateTime = dto.MeetupDateTime;
                
                await _context.SaveChangesAsync();

                _logger.LogInformation("Initial meetup arranged for loan {id}", id);
                return Ok(new { message = "Meetup arranged successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error arranging meetup for loan {id}", id);
                return StatusCode(500, "An error occurred while arranging the meetup.");
            }
        }

        /// <summary>
        /// Arranges the return meetup for a loan.
        /// </summary>
        [HttpPost("{id}/arrange-return-meetup")]
        public async Task<IActionResult> ArrangeReturnMeetup(int id, [FromBody] ArrangeMeetupDto dto)
        {
            try
            {
                var loan = await _context.Loans.FindAsync(id);

                if (loan == null)
                {
                    return NotFound();
                }

                if (loan.Status != "Active")
                {
                    return BadRequest("Loan is not active.");
                }

                loan.ReturnMeetupLocation = dto.MeetupLocation;
                loan.ReturnMeetupDateTime = dto.MeetupDateTime;
                
                await _context.SaveChangesAsync();

                _logger.LogInformation("Return meetup arranged for loan {id}", id);
                return Ok(new { message = "Return meetup arranged successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error arranging return meetup for loan {id}", id);
                return StatusCode(500, "An error occurred while arranging the return meetup.");
            }
        }

        /// <summary>
        /// Confirms that the borrower has received the comic.
        /// </summary>
        [HttpPost("{id}/confirm-received")]
        public async Task<IActionResult> ConfirmReceived(int id, [FromBody] ConfirmReceivedDto dto)
        {
            try
            {
                var loan = await _context.Loans.FindAsync(id);

                if (loan == null)
                {
                    return NotFound();
                }

                if (loan.Status != "Active")
                {
                    return BadRequest("Loan is not active.");
                }

                if (dto.IsBorrower)
                {
                    loan.BorrowerReceivedComic = true;
                }
                else
                {
                    loan.LenderConfirmedReturn = true;
                }
                
                await _context.SaveChangesAsync();

                _logger.LogInformation("Comic receipt confirmed for loan {id}", id);
                return Ok(new { message = "Receipt confirmed successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error confirming receipt for loan {id}", id);
                return StatusCode(500, "An error occurred while confirming receipt.");
            }
        }

        /// <summary>
        /// Gets the loan history for a user (completed, returned, cancelled, and overdue loans).
        /// </summary>
        [HttpGet("history/user/{userId}")]
        public async Task<ActionResult<IEnumerable<LoanHistoryDto>>> GetUserLoanHistory(int userId)
        {
            try
            {
                var loans = await _context.Loans
                    .Include(l => l.Borrower)
                    .Include(l => l.Lender)
                    .Include(l => l.Comic)
                    .ThenInclude(c => c.Owner)
                    .Include(l => l.Reviews)
                    .Where(l => (l.BorrowerId == userId || l.LenderId == userId)
                        && (l.Status == "Returned" || l.Status == "Cancelled" || l.Status == "Overdue"))
                    .OrderByDescending(l => l.DateCreated)
                    .Select(l => new LoanHistoryDto
                    {
                        Id = l.Id,
                        BorrowerId = l.BorrowerId,
                        BorrowerUsername = l.Borrower != null ? l.Borrower.Username : "",
                        LenderId = l.LenderId,
                        LenderUsername = l.Lender != null ? l.Lender.Username : "",
                        ComicId = l.ComicId,
                        ComicTitle = l.Comic != null ? l.Comic.Title : "",
                        ComicIssue = l.Comic != null ? l.Comic.IssueNumber : 0,
                        ComicPublisher = l.Comic != null ? l.Comic.Publisher : "",
                        ComicEra = l.Comic != null ? l.Comic.Era : "",
                        Status = l.Status,
                        DateCreated = l.DateCreated,
                        LoanStartDate = l.LoanStartDate,
                        LoanEndDate = l.LoanEndDate,
                        ActualReturnDate = l.ActualReturnDate,
                        LoanDurationDays = l.LoanDurationDays,
                        Notes = l.BorrowerId == userId ? l.BorrowerNotes : l.LenderNotes,
                        HasReview = l.Reviews.Any(r => r.ReviewerId == userId),
                        ReviewRating = l.Reviews.Where(r => r.ReviewerId == userId).Select(r => r.Rating).FirstOrDefault()
                    })
                    .ToListAsync();

                _logger.LogInformation("Retrieved {count} loan history records for user {userId}", loans.Count, userId);
                return Ok(loans);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting loan history for user {userId}", userId);
                return StatusCode(500, "An error occurred while retrieving loan history.");
            }
        }
    }

    // DTOs for Loan operations
    public class LoanRequestDto
    {
        public int Id { get; set; }
        public int RequesterId { get; set; }
        public string RequesterUsername { get; set; } = "";
        public int OwnerId { get; set; }
        public string OwnerUsername { get; set; } = "";
        public int RequestedComicId { get; set; }
        public string RequestedComicTitle { get; set; } = "";
        public string Status { get; set; } = "";
        public int RequestedLoanDurationDays { get; set; }
        public string? Message { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateResponded { get; set; }
        public string? ResponseMessage { get; set; }
    }

    public class LoanDto
    {
        public int Id { get; set; }
        public int BorrowerId { get; set; }
        public string BorrowerUsername { get; set; } = "";
        public int LenderId { get; set; }
        public string LenderUsername { get; set; } = "";
        public int ComicId { get; set; }
        public string ComicTitle { get; set; } = "";
        public int ComicIssue { get; set; }
        public string Status { get; set; } = "";
        public DateTime LoanStartDate { get; set; }
        public DateTime LoanEndDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public DateTime? MeetupDateTime { get; set; }
        public string? MeetupLocation { get; set; }
        public DateTime? ReturnMeetupDateTime { get; set; }
        public string? ReturnMeetupLocation { get; set; }
        public bool BorrowerReceivedComic { get; set; }
        public bool LenderConfirmedReturn { get; set; }
    }

    public class CreateLoanRequestDto
    {
        public int ComicId { get; set; }
        public int BorrowerId { get; set; }
        public DateTime RequestedReturnDate { get; set; }
        public string? Message { get; set; }
    }

    public class DeclineRequestDto
    {
        public string? Message { get; set; }
    }

    public class LoanHistoryDto
    {
        public int Id { get; set; }
        public int BorrowerId { get; set; }
        public string BorrowerUsername { get; set; } = "";
        public int LenderId { get; set; }
        public string LenderUsername { get; set; } = "";
        public int ComicId { get; set; }
        public string ComicTitle { get; set; } = "";
        public int ComicIssue { get; set; }
        public string ComicPublisher { get; set; } = "";
        public string ComicEra { get; set; } = "";
        public string Status { get; set; } = "";
        public DateTime DateCreated { get; set; }
        public DateTime? LoanStartDate { get; set; }
        public DateTime LoanEndDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public int LoanDurationDays { get; set; }
        public string? Notes { get; set; }
        public bool HasReview { get; set; }
        public int ReviewRating { get; set; }
    }

    public class ArrangeMeetupDto
    {
        public string MeetupLocation { get; set; } = "";
        public DateTime MeetupDateTime { get; set; }
        public string? Notes { get; set; }
        public bool IsReturnMeetup { get; set; }
    }

    public class ConfirmReceivedDto
    {
        public bool IsBorrower { get; set; }
    }
}
