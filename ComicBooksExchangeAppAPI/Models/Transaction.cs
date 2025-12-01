namespace ComicBooksExchangeAppAPI.Models
{
    /// <summary>
    /// Represents a transaction record for a completed exchange.
    /// Maintains a permanent record of all exchanges for trust and tracking purposes.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Gets or sets the unique identifier for the transaction.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the exchange that generated this transaction.
        /// </summary>
        public int ExchangeId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the associated exchange.
        /// </summary>
        public virtual Exchange? Exchange { get; set; }

        /// <summary>
        /// Gets or sets a transaction reference number for tracking and disputes.
        /// </summary>
        public string ReferenceNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the current status of the transaction (e.g., "Pending", "InTransit", "Received", "Completed", "Disputed").
        /// </summary>
        public string Status { get; set; } = "Pending";

        /// <summary>
        /// Gets or sets the date when the transaction was initiated.
        /// </summary>
        public DateTime DateInitiated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the date when the shipment was sent.
        /// </summary>
        public DateTime? DateShipped { get; set; }

        /// <summary>
        /// Gets or sets the date when the shipment was confirmed received.
        /// </summary>
        public DateTime? DateReceived { get; set; }

        /// <summary>
        /// Gets or sets the tracking number for the shipment if provided.
        /// </summary>
        public string? TrackingNumber { get; set; }

        /// <summary>
        /// Gets or sets notes about the transaction condition upon receipt.
        /// </summary>
        public string? ReceivedConditionNotes { get; set; }

        /// <summary>
        /// Gets or sets whether there is a dispute or issue with this transaction.
        /// </summary>
        public bool HasDispute { get; set; }

        /// <summary>
        /// Gets or sets details about any dispute that has been raised.
        /// </summary>
        public string? DisputeDetails { get; set; }
    }
}
