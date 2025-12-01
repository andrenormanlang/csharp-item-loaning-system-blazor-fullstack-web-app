namespace ComicBooksExchangeAppAPI.Models
{
    /// <summary>
    /// Represents a comic book in the exchange marketplace.
    /// Includes detailed information for collectors including grading, condition, and era information.
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
        /// Gets or sets the primary publisher of the comic (e.g., Marvel, DC, Vertigo).
        /// </summary>
        public string Publisher { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the primary characters featured in the comic.
        /// </summary>
        public string Characters { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the original cover price in cents for historical context.
        /// </summary>
        public decimal OriginalCoverPrice { get; set; }

        /// <summary>
        /// Gets or sets the current estimated market value in dollars.
        /// </summary>
        public decimal EstimatedValue { get; set; }

        /// <summary>
        /// Gets or sets the condition grade of the comic (e.g., "Mint", "Near Mint", "Very Fine", "Fine", "Very Good", "Good", "Fair", "Poor").
        /// </summary>
        public string ConditionGrade { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detailed description of the comic's condition (creases, stains, spine damage, etc.).
        /// </summary>
        public string ConditionDescription { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether this comic has been professionally graded by CGC or CBCS.
        /// </summary>
        public bool IsProfessionallyGraded { get; set; }

        /// <summary>
        /// Gets or sets the grading company and grade value if professionally graded (e.g., "CGC 9.2").
        /// </summary>
        public string? ProfessionalGradeInfo { get; set; }

        /// <summary>
        /// Gets or sets the era of the comic (e.g., "Golden Age", "Silver Age", "Bronze Age", "Modern Age").
        /// </summary>
        public string Era { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether this is the first appearance of a major character or key issue.
        /// </summary>
        public bool IsKeyIssue { get; set; }

        /// <summary>
        /// Gets or sets notes about what makes this a key issue.
        /// </summary>
        public string? KeyIssueDescription { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the owner/collector offering this comic for exchange.
        /// </summary>
        public int OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the owner of the comic.
        /// </summary>
        public virtual User? Owner { get; set; }

        /// <summary>
        /// Gets or sets whether this comic is currently available for exchange.
        /// </summary>
        public bool IsAvailable { get; set; } = true;

        /// <summary>
        /// Gets or sets the date when the comic was listed in the marketplace.
        /// </summary>
        public DateTime DateListed { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets optional notes from the collector about the comic's history or significance.
        /// </summary>
        public string? CollectorNotes { get; set; }
    }
}
