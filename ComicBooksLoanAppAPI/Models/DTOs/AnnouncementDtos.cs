namespace ComicBooksLoanAppAPI.Models.DTOs
{
    /// <summary>
    /// DTO for creating a new announcement.
    /// </summary>
    public class CreateAnnouncementDto
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Type { get; set; } = "General";
    }

    /// <summary>
    /// DTO for updating an existing announcement.
    /// </summary>
    public class UpdateAnnouncementDto
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Type { get; set; }
        public bool? IsActive { get; set; }
    }

    /// <summary>
    /// DTO for announcement display.
    /// </summary>
    public class AnnouncementDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public string CreatedByUsername { get; set; } = string.Empty;
    }
}
