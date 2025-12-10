namespace ComicBooksLoanAppAPI.Models
{
    /// <summary>
    /// Represents a private message between two community members.
    /// Enables direct communication for discussing comics, loans, and building connections.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Gets or sets the unique identifier for the message.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user sending the message.
        /// </summary>
        public int SenderId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the sender.
        /// </summary>
        public virtual User? Sender { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user receiving the message.
        /// </summary>
        public int ReceiverId { get; set; }

        /// <summary>
        /// Gets or sets the navigation property to the receiver.
        /// </summary>
        public virtual User? Receiver { get; set; }

        /// <summary>
        /// Gets or sets the message content.
        /// </summary>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date and time when the message was sent.
        /// </summary>
        public DateTime SentDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets whether the message has been read by the receiver.
        /// </summary>
        public bool IsRead { get; set; } = false;

        /// <summary>
        /// Gets or sets optional subject line for the message.
        /// </summary>
        public string? Subject { get; set; }
    }
}
