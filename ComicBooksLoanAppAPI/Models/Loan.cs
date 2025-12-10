namespace ComicBooksLoanAppAPI.Models
{
    /// <summary>
    /// Represents an active comic book loan in the lending library.
    /// Tracks the borrowed comic, loan period, and return status.
    /// Loans are facilitated through local meetups in Skåne, Sweden.
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// Gets or sets the unique identifier for the loan.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who is borrowing the comic.
        /// </summary>
        public int BorrowerId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the borrower.
        /// </summary>
        public virtual User? Borrower { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who owns the comic being lent.
        /// </summary>
        public int LenderId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the lender.
        /// </summary>
        public virtual User? Lender { get; set; }

        /// <summary>
        /// Gets or sets the ID of the comic being borrowed.
        /// </summary>
        public int ComicId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the borrowed comic.
        /// </summary>
        public virtual Comic? Comic { get; set; }

        /// <summary>
        /// Gets or sets the current status of the loan.
        /// Values: "Pending", "Active", "Returned", "Overdue", "Cancelled"
        /// </summary>
        public string Status { get; set; } = "Pending";

        /// <summary>
        /// Gets or sets the date when the loan was created/requested.
        /// </summary>
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date when the loan started (comic was handed over during meetup).
        /// </summary>
        public DateTime? LoanStartDate { get; set; }

        /// <summary>
        /// Gets or sets the expected return date for the loan.
        /// </summary>
        public DateTime LoanEndDate { get; set; }

        /// <summary>
        /// Gets or sets the actual return date when comic was returned during meetup.
        /// </summary>
        public DateTime? ActualReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the duration of the loan in days.
        /// </summary>
        public int LoanDurationDays { get; set; }

        /// <summary>
        /// Gets or sets notes from the borrower about the loan.
        /// </summary>
        public string? BorrowerNotes { get; set; }

        /// <summary>
        /// Gets or sets notes from the lender about the loan.
        /// </summary>
        public string? LenderNotes { get; set; }

        /// <summary>
        /// Gets or sets the agreed meetup location for comic handover.
        /// </summary>
        public string? MeetupLocation { get; set; }

        /// <summary>
        /// Gets or sets the agreed date and time for the initial meetup.
        /// </summary>
        public DateTime? MeetupDateTime { get; set; }

        /// <summary>
        /// Gets or sets the agreed meetup location for comic return.
        /// </summary>
        public string? ReturnMeetupLocation { get; set; }

        /// <summary>
        /// Gets or sets the agreed date and time for the return meetup.
        /// </summary>
        public DateTime? ReturnMeetupDateTime { get; set; }

        /// <summary>
        /// Gets or sets whether the borrower has confirmed receiving the comic.
        /// </summary>
        public bool BorrowerReceivedComic { get; set; }

        /// <summary>
        /// Gets or sets whether the lender has confirmed comic was returned.
        /// </summary>
        public bool LenderConfirmedReturn { get; set; }

        /// <summary>
        /// Gets or sets the ID of the loan request that initiated this loan.
        /// </summary>
        public int? LoanRequestId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the loan request.
        /// </summary>
        public virtual LoanRequest? LoanRequest { get; set; }

        /// <summary>
        /// Gets or sets the collection of reviews for this loan.
        /// </summary>
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
