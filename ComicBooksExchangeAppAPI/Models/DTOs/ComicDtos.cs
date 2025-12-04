using ComicBooksExchangeAppAPI.Validators;
using System.ComponentModel.DataAnnotations;

namespace ComicBooksExchangeAppAPI.Models.DTOs
{
    /// <summary>
    /// Data Transfer Object for creating a new comic listing.
    /// Used for API requests to add comics to the marketplace.
    /// </summary>
    public class CreateComicDto
    {
        /// <summary>
        /// Gets or sets the comic title.
        /// </summary>
        [Required(ErrorMessage = "Comic title is required.")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Title must be between 1 and 200 characters.")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the issue number.
        /// </summary>
        [Required(ErrorMessage = "Issue number is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Issue number must be greater than 0.")]
        public int IssueNumber { get; set; }

        /// <summary>
        /// Gets or sets the publication date.
        /// </summary>
        [Required(ErrorMessage = "Publication date is required.")]
        public DateTime PublicationDate { get; set; }

        /// <summary>
        /// Gets or sets the publisher name.
        /// </summary>
        [Required(ErrorMessage = "Publisher is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Publisher must be between 1 and 100 characters.")]
        public string Publisher { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the characters featured.
        /// </summary>
        [StringLength(500, ErrorMessage = "Characters field cannot exceed 500 characters.")]
        public string Characters { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the original cover price.
        /// </summary>
        [Required(ErrorMessage = "Original cover price is required.")]
        [Range(0, 9999.99, ErrorMessage = "Original cover price must be between 0 and 9999.99.")]
        public decimal OriginalCoverPrice { get; set; }


        /// <summary>
        /// Gets or sets the condition grade.
        /// </summary>
        [Required(ErrorMessage = "Condition grade is required.")]
        [ValidConditionGrade(ErrorMessage = "Invalid condition grade.")]
        public string ConditionGrade { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the detailed condition description.
        /// </summary>
        [StringLength(1000, ErrorMessage = "Condition description cannot exceed 1000 characters.")]
        public string ConditionDescription { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether this comic is professionally graded.
        /// </summary>
        public bool IsProfessionallyGraded { get; set; }

        /// <summary>
        /// Gets or sets the professional grade information.
        /// </summary>
        [StringLength(50, ErrorMessage = "Professional grade info cannot exceed 50 characters.")]
        public string? ProfessionalGradeInfo { get; set; }

        /// <summary>
        /// Gets or sets the comic era.
        /// </summary>
        [Required(ErrorMessage = "Era is required.")]
        [ValidEra(ErrorMessage = "Invalid comic era.")]
        public string Era { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether this is a key issue.
        /// </summary>
        public bool IsKeyIssue { get; set; }

        /// <summary>
        /// Gets or sets the key issue description.
        /// </summary>
        [StringLength(500, ErrorMessage = "Key issue description cannot exceed 500 characters.")]
        public string? KeyIssueDescription { get; set; }

        /// <summary>
        /// Gets or sets the owner user ID.
        /// </summary>
        [Required(ErrorMessage = "Owner ID is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Owner ID must be valid.")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the owner notes.
        /// </summary>
        [StringLength(1000, ErrorMessage = "Owner notes cannot exceed 1000 characters.")]
        public string? OwnerNotes { get; set; }
    }

    /// <summary>
    /// Data Transfer Object for displaying comic information.
    /// Used for API responses.
    /// </summary>
    public class ComicDto
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the comic title.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the issue number.
        /// </summary>
        public int IssueNumber { get; set; }

        /// <summary>
        /// Gets or sets the publication date.
        /// </summary>
        public DateTime PublicationDate { get; set; }

        /// <summary>
        /// Gets or sets the publisher name.
        /// </summary>
        public string Publisher { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the characters featured.
        /// </summary>
        public string Characters { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the original cover price.
        /// </summary>
        public decimal OriginalCoverPrice { get; set; }


        /// <summary>
        /// Gets or sets the condition grade.
        /// </summary>
        public string ConditionGrade { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the condition description.
        /// </summary>
        public string ConditionDescription { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether professionally graded.
        /// </summary>
        public bool IsProfessionallyGraded { get; set; }

        /// <summary>
        /// Gets or sets the professional grade info.
        /// </summary>
        public string? ProfessionalGradeInfo { get; set; }

        /// <summary>
        /// Gets or sets the comic era.
        /// </summary>
        public string Era { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether this is a key issue.
        /// </summary>
        public bool IsKeyIssue { get; set; }

        /// <summary>
        /// Gets or sets the key issue description.
        /// </summary>
        public string? KeyIssueDescription { get; set; }

        /// <summary>
        /// Gets or sets the owner ID.
        /// </summary>
        public int OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the owner's username.
        /// </summary>
        public string OwnerUsername { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets whether available for loan.
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Gets or sets whether the comic is currently on loan.
        /// </summary>
        public bool IsOnLoan { get; set; }

        /// <summary>
        /// Gets or sets the expected return date if on loan.
        /// </summary>
        public DateTime? LoanReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the listing date.
        /// </summary>
        public DateTime DateListed { get; set; }

        /// <summary>
        /// Gets or sets the owner notes.
        /// </summary>
        public string? OwnerNotes { get; set; }

        /// <summary>
        /// Gets or sets the URL to the comic book cover image.
        /// </summary>
        public string? CoverImageUrl { get; set; }
    }
}
