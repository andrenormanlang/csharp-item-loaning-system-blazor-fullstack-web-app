using System.ComponentModel.DataAnnotations.Schema;

namespace ComicBooksExchangeAppAPI.Models
{
    /// <summary>
    /// Represents a user in the comic books lending library.
    /// Designed for mature comic readers with focus on reading preferences and community trust.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the username for the member.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the full name of the member.
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the email address for contact and notifications.
        /// </summary>
        public string Email { get; set; } = string.Empty;


        /// <summary>
        /// Gets or sets the preferred eras of comics the collector enjoys.
        /// </summary>
        public string PreferredEras { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the favorite characters or franchises.
        /// </summary>
        public string FavoriteCharacters { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a biography or collecting history for the member.
        /// </summary>
        public string? Biography { get; set; }

        /// <summary>
        /// Gets or sets the total number of successful loans completed by this user.
        /// </summary>
        public int SuccessfulLoans { get; set; }

        /// <summary>
        /// Gets or sets the average rating given by lending partners (0-5 scale).
        /// </summary>
        public decimal AverageRating { get; set; }

        /// <summary>
        /// Gets or sets the date when the user joined the platform.
        /// </summary>
        public DateTime MemberSince { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets whether this user's profile has been verified by the platform.
        /// </summary>
        public bool IsVerified { get; set; }

        /// <summary>
        /// Gets or sets the URL to the user's avatar image.
        /// </summary>
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the hashed password for user authentication.
        /// </summary>
        public string PasswordHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the navigation property for comics owned by this user.
        /// </summary>
        public virtual ICollection<Comic> Comics { get; set; } = new List<Comic>();

        /// <summary>
        /// Gets or sets the navigation property for loan requests initiated by this user.
        /// </summary>
        public virtual ICollection<LoanRequest> LoanRequestsInitiated { get; set; } = new List<LoanRequest>();

        /// <summary>
        /// Gets or sets the navigation property for loans where this user is the borrower.
        /// </summary>
        public virtual ICollection<Loan> LoansAsBorrower { get; set; } = new List<Loan>();

        /// <summary>
        /// Gets or sets the navigation property for loans where this user is the lender.
        /// </summary>
        public virtual ICollection<Loan> LoansAsLender { get; set; } = new List<Loan>();

        /// <summary>
        /// Gets or sets the navigation property for reviews received by this user.
        /// </summary>
        public virtual ICollection<Review> ReviewsReceived { get; set; } = new List<Review>();
    }
}
