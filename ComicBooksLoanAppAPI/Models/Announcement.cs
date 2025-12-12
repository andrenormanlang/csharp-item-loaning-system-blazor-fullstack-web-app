namespace ComicBooksLoanAppAPI.Models
{
    /// <summary>
    /// Represents a platform announcement or news update created by admin.
    /// </summary>
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public AnnouncementType Type { get; set; } = AnnouncementType.General;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
        public int CreatedByUserId { get; set; }

        // Navigation property
        public User? CreatedBy { get; set; }
    }

    public enum AnnouncementType
    {
        General,
        Feature,
        Maintenance,
        Event,
        Update
    }
}
