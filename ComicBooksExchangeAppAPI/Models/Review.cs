namespace ComicBooksExchangeAppAPI.Models
{
    /// <summary>
    /// Represents a review and rating given by one member to another after a completed loan.
    /// Essential for building trust in the lending library and tracking member reliability.
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Gets or sets the unique identifier for the review.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user writing the review.
        /// </summary>
        public int ReviewerId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the reviewer.
        /// </summary>
        public virtual User? Reviewer { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user being reviewed.
        /// </summary>
        public int ReviewedUserId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the user being reviewed.
        /// </summary>
        public virtual User? ReviewedUser { get; set; }

        /// <summary>
        /// Gets or sets the ID of the loan that prompted this review.
        /// </summary>
        public int? LoanId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the loan being reviewed.
        /// </summary>
        public virtual Loan? Loan { get; set; }

        /// <summary>
        /// Gets or sets the numeric rating on a 1-5 scale.
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets detailed comments about the loan experience.
        /// </summary>
        public string? Comment { get; set; }

        /// <summary>
        /// Gets or sets the date when the review was submitted.
        /// </summary>
        public DateTime DateSubmitted { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets whether the comic arrived in the condition described.
        /// </summary>
        public bool ConditionAsDescribed { get; set; }

        /// <summary>
        /// Gets or sets whether the communication with the lending partner was satisfactory.
        /// </summary>
        public bool CommunicationRating { get; set; }

        /// <summary>
        /// Gets or sets whether the shipping was packaged safely.
        /// </summary>
        public bool ShippingPackagingRating { get; set; }
    }
}
