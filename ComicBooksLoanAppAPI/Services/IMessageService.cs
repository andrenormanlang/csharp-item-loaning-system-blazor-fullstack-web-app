using ComicBooksLoanAppAPI.Models;
using ComicBooksLoanAppAPI.Models.DTOs;

namespace ComicBooksLoanAppAPI.Services
{
    /// <summary>
    /// Service interface for message-related business logic.
    /// </summary>
    public interface IMessageService
    {
        /// <summary>
        /// Sends a message from one user to another.
        /// </summary>
        /// <param name="senderId">The sender's user ID.</param>
        /// <param name="dto">The message details.</param>
        /// <returns>The created message.</returns>
        Task<Message> SendMessageAsync(int senderId, SendMessageDto dto);

        /// <summary>
        /// Gets all messages for a user (inbox + sent).
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>Collection of MessageDto objects.</returns>
        Task<IEnumerable<MessageDto>> GetMessagesForUserAsync(int userId);

        /// <summary>
        /// Gets conversation between two users.
        /// </summary>
        /// <param name="userId1">First user ID.</param>
        /// <param name="userId2">Second user ID.</param>
        /// <returns>Collection of MessageDto objects.</returns>
        Task<IEnumerable<MessageDto>> GetConversationAsync(int userId1, int userId2);

        /// <summary>
        /// Gets unread messages for a user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>Collection of unread MessageDto objects.</returns>
        Task<IEnumerable<MessageDto>> GetUnreadMessagesAsync(int userId);

        /// <summary>
        /// Marks a message as read.
        /// </summary>
        /// <param name="messageId">The message ID.</param>
        /// <param name="userId">The requesting user ID (must be the receiver).</param>
        /// <returns>True if successful.</returns>
        Task<bool> MarkAsReadAsync(int messageId, int userId);

        /// <summary>
        /// Gets the count of unread messages for a user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>Number of unread messages.</returns>
        Task<int> GetUnreadCountAsync(int userId);

        /// <summary>
        /// Gets conversation summaries (inbox view).
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>Collection of ConversationDto objects.</returns>
        Task<IEnumerable<ConversationDto>> GetConversationsAsync(int userId);
    }
}
