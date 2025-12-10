namespace ComicBooksLoanAppAPI.Models
{
    /// <summary>
    /// Represents a loan request in the lending library.
    /// A member requests to borrow a comic from another member's collection via local meetup.
    /// </summary>
    public class LoanRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier for the loan request.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the member requesting to borrow a comic.
        /// </summary>
        public int RequesterId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the requester.
        /// </summary>
        public virtual User? Requester { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the comic owner being requested to lend.
        /// </summary>
        public int OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the comic owner.
        /// </summary>
        public virtual User? Owner { get; set; }

        /// <summary>
        /// Gets or sets the ID of the comic being requested to borrow.
        /// </summary>
        public int RequestedComicId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the comic being requested.
        /// </summary>
        public virtual Comic? RequestedComic { get; set; }

        /// <summary>
        /// Gets or sets the current status of the loan request.
        /// Values: "Pending", "Accepted", "Declined", "Cancelled", "Expired"
        /// </summary>
        public string Status { get; set; } = "Pending";

        /// <summary>
        /// Gets or sets the requested loan duration in days.
        /// </summary>
        public int RequestedLoanDurationDays { get; set; } = 14;

        /// <summary>
        /// Gets or sets optional message from the requester.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Gets or sets the preferred meetup method (In-Person, Local Delivery, etc.).
        /// </summary>
        public string PreferredMeetupMethod { get; set; } = "In-Person Meetup";

        /// <summary>
        /// Gets or sets suggested meetup location(s) from the requester.
        /// </summary>
        public string? SuggestedMeetupLocation { get; set; }

        /// <summary>
        /// Gets or sets the date when the request was created.
        /// </summary>
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date when the request was responded to.
        /// </summary>
        public DateTime? DateResponded { get; set; }

        /// <summary>
        /// Gets or sets the response message from the owner.
        /// </summary>
        public string? ResponseMessage { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the resulting loan if accepted.
        /// </summary>
        public virtual Loan? Loan { get; set; }
    }
}
