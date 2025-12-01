namespace ComicBooksExchangeAppAPI.Models
{
    /// <summary>
    /// Represents an exchange offer between two collectors.
    /// Tracks the lifecycle of a potential trade from initiation to completion or cancellation.
    /// </summary>
    public class Exchange
    {
        /// <summary>
        /// Gets or sets the unique identifier for the exchange.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the collector initiating the exchange offer.
        /// </summary>
        public int InitiatorId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the collector initiating the exchange.
        /// </summary>
        public virtual User? Initiator { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the comic owner being offered to exchange with.
        /// </summary>
        public int RecipientId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the comic owner receiving the offer.
        /// </summary>
        public virtual User? Recipient { get; set; }

        /// <summary>
        /// Gets or sets the ID of the comic being offered in the exchange.
        /// </summary>
        public int OfferedComicId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the comic being offered.
        /// </summary>
        public virtual Comic? OfferedComic { get; set; }

        /// <summary>
        /// Gets or sets the ID of the comic being requested in the exchange.
        /// </summary>
        public int RequestedComicId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the comic being requested.
        /// </summary>
        public virtual Comic? RequestedComic { get; set; }

        /// <summary>
        /// Gets or sets the current status of the exchange (e.g., "Pending", "Accepted", "Shipped", "Completed", "Cancelled", "Disputed").
        /// </summary>
        public string Status { get; set; } = "Pending";

        /// <summary>
        /// Gets or sets optional additional notes or terms from the initiator (e.g., willingness to include cash, condition concerns).
        /// </summary>
        public string? OfferMessage { get; set; }

        /// <summary>
        /// Gets or sets any additional value (cash) the initiator is willing to add to balance the trade.
        /// </summary>
        public decimal? AdditionalValue { get; set; }

        /// <summary>
        /// Gets or sets the date when the exchange offer was created.
        /// </summary>
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date when the exchange offer was responded to.
        /// </summary>
        public DateTime? DateResponded { get; set; }

        /// <summary>
        /// Gets or sets the date when the exchange was completed.
        /// </summary>
        public DateTime? DateCompleted { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the transaction record of this exchange.
        /// </summary>
        public virtual Transaction? Transaction { get; set; }
    }
}
