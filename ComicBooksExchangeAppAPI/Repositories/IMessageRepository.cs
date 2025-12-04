using ComicBooksExchangeAppAPI.Models;

namespace ComicBooksExchangeAppAPI.Repositories
{
    /// <summary>
    /// Repository interface for Message entity operations.
    /// Provides methods for managing private messages between community members.
    /// </summary>
    public interface IMessageRepository : IRepository<Message>
    {
        /// <summary>
        /// Gets all messages for a specific user (sent or received).
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>Collection of messages for the user.</returns>
        Task<IEnumerable<Message>> GetMessagesForUserAsync(int userId);

        /// <summary>
        /// Gets conversation between two users.
        /// </summary>
        /// <param name="userId1">First user ID.</param>
        /// <param name="userId2">Second user ID.</param>
        /// <returns>Collection of messages between the two users.</returns>
        Task<IEnumerable<Message>> GetConversationAsync(int userId1, int userId2);

        /// <summary>
        /// Gets unread messages for a user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>Collection of unread messages.</returns>
        Task<IEnumerable<Message>> GetUnreadMessagesAsync(int userId);

        /// <summary>
        /// Marks a message as read.
        /// </summary>
        /// <param name="messageId">The message ID.</param>
        /// <returns>True if successful, false otherwise.</returns>
        Task<bool> MarkAsReadAsync(int messageId);

        /// <summary>
        /// Gets the count of unread messages for a user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>Number of unread messages.</returns>
        Task<int> GetUnreadCountAsync(int userId);
    }
}
