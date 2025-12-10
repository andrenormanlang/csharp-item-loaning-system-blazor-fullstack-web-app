using System.ComponentModel.DataAnnotations;

namespace ComicBooksLoanAppAPI.Models.DTOs
{
    /// <summary>
    /// Data Transfer Object for sending a new message.
    /// </summary>
    public class SendMessageDto
    {
        /// <summary>
        /// Gets or sets the receiver's user ID.
        /// </summary>
        [Required(ErrorMessage = "Receiver ID is required.")]
        public int ReceiverId { get; set; }

        /// <summary>
        /// Gets or sets the message subject (optional).
        /// </summary>
        [StringLength(200, ErrorMessage = "Subject cannot exceed 200 characters.")]
        public string? Subject { get; set; }

        /// <summary>
        /// Gets or sets the message content.
        /// </summary>
        [Required(ErrorMessage = "Message content is required.")]
        [StringLength(2000, MinimumLength = 1, ErrorMessage = "Message must be between 1 and 2000 characters.")]
        public string Content { get; set; } = string.Empty;
    }

    /// <summary>
    /// Data Transfer Object for displaying message information.
    /// </summary>
    public class MessageDto
    {
        /// <summary>
        /// Gets or sets the message ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the sender's ID.
        /// </summary>
        public int SenderId { get; set; }

        /// <summary>
        /// Gets or sets the sender's username.
        /// </summary>
        public string SenderUsername { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the sender's full name.
        /// </summary>
        public string SenderFullName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the receiver's ID.
        /// </summary>
        public int ReceiverId { get; set; }

        /// <summary>
        /// Gets or sets the receiver's username.
        /// </summary>
        public string ReceiverUsername { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the receiver's full name.
        /// </summary>
        public string ReceiverFullName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the message subject.
        /// </summary>
        public string? Subject { get; set; }

        /// <summary>
        /// Gets or sets the message content.
        /// </summary>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets when the message was sent.
        /// </summary>
        public DateTime SentDate { get; set; }

        /// <summary>
        /// Gets or sets whether the message has been read.
        /// </summary>
        public bool IsRead { get; set; }
    }

    /// <summary>
    /// Data Transfer Object for a conversation summary (list of messages with one other user).
    /// </summary>
    public class ConversationDto
    {
        /// <summary>
        /// Gets or sets the other user's ID.
        /// </summary>
        public int OtherUserId { get; set; }

        /// <summary>
        /// Gets or sets the other user's username.
        /// </summary>
        public string OtherUsername { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the other user's full name.
        /// </summary>
        public string OtherFullName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the other user's profile image URL.
        /// </summary>
        public string? OtherUserImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the last message in the conversation.
        /// </summary>
        public string LastMessagePreview { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date of the last message.
        /// </summary>
        public DateTime LastMessageDate { get; set; }

        /// <summary>
        /// Gets or sets the number of unread messages in this conversation.
        /// </summary>
        public int UnreadCount { get; set; }
    }
}
