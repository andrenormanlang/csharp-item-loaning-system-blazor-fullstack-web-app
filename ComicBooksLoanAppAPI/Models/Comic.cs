namespace ComicBooksLoanAppAPI.Models
{
    /// <summary>
    /// Represents a comic book in the lending library.
    /// Includes information about the comic's condition and availability for lending.
    /// </summary>
    public class Comic
    {
        /// <summary>
        /// Gets or sets the unique identifier for the comic.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the comic book series.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the issue number within the series.
        /// </summary>
        public int IssueNumber { get; set; }

        /// <summary>
        /// Gets or sets the publication date of the comic.
        /// </summary>
        public DateTime PublicationDate { get; set; }

        /// <summary>
        /// Gets or sets the primary publisher of the comic (e.g., Marvel, DC, Dark Horse).
        /// </summary>
        public string Publisher { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the primary characters featured in the comic.
        /// </summary>
        public string Characters { get; set; } = string.Empty;

       
        public string Era { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the genre of the comic (e.g., "Superhero", "Horror", "Sci-Fi", "Fantasy").
        /// </summary>
        public string Genre { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the condition grade of the comic (e.g., "Mint", "Near Mint", "Very Fine", "Fine", "Very Good", "Good", "Fair", "Poor").
        /// </summary>
        public string ConditionGrade { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detailed description of the comic's condition.
        /// </summary>
        public string ConditionDescription { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a brief description or synopsis of this issue.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the owner who is lending this comic.
        /// </summary>
        public int OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the owner of the comic.
        /// </summary>
        public virtual User? Owner { get; set; }

        /// <summary>
        /// Gets or sets whether this comic is currently available for loan.
        /// </summary>
        public bool IsAvailable { get; set; } = true;

        /// <summary>
        /// Gets or sets whether this comic is currently on loan.
        /// </summary>
        public bool IsOnLoan { get; set; } = false;

        /// <summary>
        /// Gets or sets the ID of the current active loan (if on loan).
        /// </summary>
        public int? CurrentLoanId { get; set; }

        /// <summary>
        /// Gets or sets the expected return date if the comic is on loan.
        /// </summary>
        public DateTime? LoanReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the date when the comic was added to the library.
        /// </summary>
        public DateTime DateListed { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets optional notes from the owner about the comic.
        /// </summary>
        public string? OwnerNotes { get; set; }

        /// <summary>
        /// Gets or sets the URL to the comic book cover image.
        /// </summary>
        public string? CoverImageUrl { get; set; } = "/images/comics/default-cover.svg";
    }
}
