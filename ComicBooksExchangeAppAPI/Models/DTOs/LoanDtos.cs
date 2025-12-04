using System.ComponentModel.DataAnnotations;

namespace ComicBooksExchangeAppAPI.Models.DTOs
{
    /// <summary>
    /// Data Transfer Object for creating a new loan request.
    /// </summary>
    public class CreateLoanRequestDto
    {
        /// <summary>
        /// Gets or sets the ID of the comic being requested to borrow.
        /// </summary>
        [Required(ErrorMessage = "Requested comic ID is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Requested comic ID must be valid.")]
        public int RequestedComicId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the comic being offered in return.
        /// </summary>
        [Required(ErrorMessage = "Offered comic ID is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Offered comic ID must be valid.")]
        public int OfferedComicId { get; set; }

        /// <summary>
        /// Gets or sets the requested loan duration in days.
        /// </summary>
        [Required(ErrorMessage = "Loan duration is required.")]
        [Range(7, 90, ErrorMessage = "Loan duration must be between 7 and 90 days.")]
        public int RequestedLoanDurationDays { get; set; } = 30;

        /// <summary>
        /// Gets or sets optional message from the requester.
        /// </summary>
        [StringLength(1000, ErrorMessage = "Message cannot exceed 1000 characters.")]
        public string? Message { get; set; }

        /// <summary>
        /// Gets or sets the preferred shipping method.
        /// </summary>
        [StringLength(50, ErrorMessage = "Shipping method cannot exceed 50 characters.")]
        public string ShippingMethod { get; set; } = "Mail";

        /// <summary>
        /// Gets or sets whether insured shipping is requested.
        /// </summary>
        public bool WithInsurance { get; set; } = true;
    }

    /// <summary>
    /// Data Transfer Object for responding to a loan request.
    /// </summary>
    public class RespondToLoanRequestDto
    {
        /// <summary>
        /// Gets or sets whether the request is accepted.
        /// </summary>
        [Required]
        public bool Accept { get; set; }

        /// <summary>
        /// Gets or sets the response message.
        /// </summary>
        [StringLength(1000, ErrorMessage = "Response message cannot exceed 1000 characters.")]
        public string? ResponseMessage { get; set; }
    }

    /// <summary>
    /// Data Transfer Object for displaying loan request information.
    /// </summary>
    public class LoanRequestDto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the loan request.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the requester's user ID.
        /// </summary>
        public int RequesterId { get; set; }

        /// <summary>
        /// Gets or sets the requester's username.
        /// </summary>
        public string RequesterUsername { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the owner's user ID.
        /// </summary>
        public int OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the owner's username.
        /// </summary>
        public string OwnerUsername { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the requested comic ID.
        /// </summary>
        public int RequestedComicId { get; set; }

        /// <summary>
        /// Gets or sets the requested comic title.
        /// </summary>
        public string RequestedComicTitle { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the requested comic issue number.
        /// </summary>
        public int RequestedComicIssueNumber { get; set; }

        /// <summary>
        /// Gets or sets the offered comic ID.
        /// </summary>
        public int OfferedComicId { get; set; }

        /// <summary>
        /// Gets or sets the offered comic title.
        /// </summary>
        public string OfferedComicTitle { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the offered comic issue number.
        /// </summary>
        public int OfferedComicIssueNumber { get; set; }

        /// <summary>
        /// Gets or sets the current status.
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the requested loan duration in days.
        /// </summary>
        public int RequestedLoanDurationDays { get; set; }

        /// <summary>
        /// Gets or sets the message from requester.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Gets or sets the shipping method.
        /// </summary>
        public string ShippingMethod { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether insured shipping is requested.
        /// </summary>
        public bool WithInsurance { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the response date.
        /// </summary>
        public DateTime? DateResponded { get; set; }

        /// <summary>
        /// Gets or sets the response message.
        /// </summary>
        public string? ResponseMessage { get; set; }
    }

    /// <summary>
    /// Data Transfer Object for displaying loan information.
    /// </summary>
    public class LoanDto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the loan.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the borrower's user ID.
        /// </summary>
        public int BorrowerId { get; set; }

        /// <summary>
        /// Gets or sets the borrower's username.
        /// </summary>
        public string BorrowerUsername { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the lender's user ID.
        /// </summary>
        public int LenderId { get; set; }

        /// <summary>
        /// Gets or sets the lender's username.
        /// </summary>
        public string LenderUsername { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the borrowed comic ID.
        /// </summary>
        public int BorrowedComicId { get; set; }

        /// <summary>
        /// Gets or sets the borrowed comic title.
        /// </summary>
        public string BorrowedComicTitle { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the borrowed comic issue number.
        /// </summary>
        public int BorrowedComicIssueNumber { get; set; }

        /// <summary>
        /// Gets or sets the offered comic ID.
        /// </summary>
        public int OfferedComicId { get; set; }

        /// <summary>
        /// Gets or sets the offered comic title.
        /// </summary>
        public string OfferedComicTitle { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the offered comic issue number.
        /// </summary>
        public int OfferedComicIssueNumber { get; set; }

        /// <summary>
        /// Gets or sets the current status.
        /// </summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the loan start date.
        /// </summary>
        public DateTime LoanStartDate { get; set; }

        /// <summary>
        /// Gets or sets the expected loan end date.
        /// </summary>
        public DateTime LoanEndDate { get; set; }

        /// <summary>
        /// Gets or sets the actual return date.
        /// </summary>
        public DateTime? ActualReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the loan duration in days.
        /// </summary>
        public int LoanDurationDays { get; set; }

        /// <summary>
        /// Gets or sets the remaining days until return.
        /// </summary>
        public int RemainingDays { get; set; }

        /// <summary>
        /// Gets or sets whether the loan is overdue.
        /// </summary>
        public bool IsOverdue { get; set; }

        /// <summary>
        /// Gets or sets any notes about the loan.
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// Gets or sets whether the borrower has received the comic.
        /// </summary>
        public bool BorrowerReceivedComic { get; set; }

        /// <summary>
        /// Gets or sets whether the lender has received the offered comic.
        /// </summary>
        public bool LenderReceivedComic { get; set; }

        /// <summary>
        /// Gets or sets whether the borrower has returned the comic.
        /// </summary>
        public bool BorrowerReturnedComic { get; set; }

        /// <summary>
        /// Gets or sets whether the lender has returned the offered comic.
        /// </summary>
        public bool LenderReturnedComic { get; set; }

        /// <summary>
        /// Gets or sets the tracking number to borrower.
        /// </summary>
        public string? TrackingNumberToBorrower { get; set; }

        /// <summary>
        /// Gets or sets the tracking number to lender.
        /// </summary>
        public string? TrackingNumberToLender { get; set; }

        /// <summary>
        /// Gets or sets the return tracking number from borrower.
        /// </summary>
        public string? ReturnTrackingNumberFromBorrower { get; set; }

        /// <summary>
        /// Gets or sets the return tracking number from lender.
        /// </summary>
        public string? ReturnTrackingNumberFromLender { get; set; }
    }

    /// <summary>
    /// DTO for updating loan tracking information.
    /// </summary>
    public class UpdateLoanTrackingDto
    {
        /// <summary>
        /// Gets or sets the tracking number.
        /// </summary>
        [StringLength(100, ErrorMessage = "Tracking number cannot exceed 100 characters.")]
        public string? TrackingNumber { get; set; }
    }

    /// <summary>
    /// DTO for confirming receipt of a comic in a loan.
    /// </summary>
    public class ConfirmReceiptDto
    {
        /// <summary>
        /// Gets or sets any condition notes upon receipt.
        /// </summary>
        [StringLength(500, ErrorMessage = "Condition notes cannot exceed 500 characters.")]
        public string? ConditionNotes { get; set; }
    }
}
