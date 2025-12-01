namespace ComicBooksExchangeAppAPI.Models
{
    /// <summary>
    /// Represents a user in the comic books exchange marketplace.
    /// Designed for mature collectors with focus on collector profiles and trust indicators.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the username for the collector.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the full name of the collector.
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the email address for contact and notifications.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the phone number for exchange coordination.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user's primary collecting focus area (e.g., "Bronze Age Marvel", "DC Silver Age", "Indie Comics").
        /// </summary>
        public string CollectingFocus { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the preferred eras of comics the collector is interested in.
        /// </summary>
        public string PreferredEras { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the favorite characters or franchises the collector pursues.
        /// </summary>
        public string FavoriteCharacters { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a biography or collecting story for the collector.
        /// </summary>
        public string? Biography { get; set; }

        /// <summary>
        /// Gets or sets the total number of successful exchanges completed by this user.
        /// </summary>
        public int SuccessfulExchanges { get; set; }

        /// <summary>
        /// Gets or sets the average rating given by exchange partners (0-5 scale).
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
        /// Gets or sets the user's preferred method of exchange (mail, local pickup, hybrid).
        /// </summary>
        public string PreferredExchangeMethod { get; set; } = "Mail";

        /// <summary>
        /// Gets or sets the user's location for local exchange considerations.
        /// </summary>
        public string? Location { get; set; }

        /// <summary>
        /// Gets or sets notes about the collector's preferences and trading style.
        /// </summary>
        public string? TradePreferences { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for comics owned by this user.
        /// </summary>
        public virtual ICollection<Comic> Comics { get; set; } = new List<Comic>();

        /// <summary>
        /// Gets or sets the navigation property for exchanges initiated by this user.
        /// </summary>
        public virtual ICollection<Exchange> ExchangesInitiated { get; set; } = new List<Exchange>();

        /// <summary>
        /// Gets or sets the navigation property for reviews received by this user.
        /// </summary>
        public virtual ICollection<Review> ReviewsReceived { get; set; } = new List<Review>();
    }
}
