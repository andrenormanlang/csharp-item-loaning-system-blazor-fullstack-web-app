using Microsoft.EntityFrameworkCore;
using ComicBooksExchangeAppAPI.Data;
using ComicBooksExchangeAppAPI.Models;

namespace ComicBooksExchangeAppAPI.Repositories
{
    /// <summary>
    /// Repository implementation for Message entity operations.
    /// </summary>
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        /// <summary>
        /// Initializes a new instance of the MessageRepository class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public MessageRepository(ComicBooksExchangeDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets all messages for a specific user (sent or received).
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>Collection of messages for the user, ordered by sent date descending.</returns>
        public async Task<IEnumerable<Message>> GetMessagesForUserAsync(int userId)
        {
            return await _context.Messages
                .Include(m => m.Sender)
                .Include(m => m.Receiver)
                .Where(m => m.SenderId == userId || m.ReceiverId == userId)
                .OrderByDescending(m => m.SentDate)
                .ToListAsync();
        }

        /// <summary>
        /// Gets conversation between two users.
        /// </summary>
        /// <param name="userId1">First user ID.</param>
        /// <param name="userId2">Second user ID.</param>
        /// <returns>Collection of messages between the two users, ordered by sent date.</returns>
        public async Task<IEnumerable<Message>> GetConversationAsync(int userId1, int userId2)
        {
            return await _context.Messages
                .Include(m => m.Sender)
                .Include(m => m.Receiver)
                .Where(m => (m.SenderId == userId1 && m.ReceiverId == userId2) ||
                           (m.SenderId == userId2 && m.ReceiverId == userId1))
                .OrderBy(m => m.SentDate)
                .ToListAsync();
        }

        /// <summary>
        /// Gets unread messages for a user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>Collection of unread messages, ordered by sent date descending.</returns>
        public async Task<IEnumerable<Message>> GetUnreadMessagesAsync(int userId)
        {
            return await _context.Messages
                .Include(m => m.Sender)
                .Where(m => m.ReceiverId == userId && !m.IsRead)
                .OrderByDescending(m => m.SentDate)
                .ToListAsync();
        }

        /// <summary>
        /// Marks a message as read.
        /// </summary>
        /// <param name="messageId">The message ID.</param>
        /// <returns>True if successful, false otherwise.</returns>
        public async Task<bool> MarkAsReadAsync(int messageId)
        {
            var message = await _context.Messages.FindAsync(messageId);
            if (message == null)
                return false;

            message.IsRead = true;
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Gets the count of unread messages for a user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>Number of unread messages.</returns>
        public async Task<int> GetUnreadCountAsync(int userId)
        {
            return await _context.Messages
                .Where(m => m.ReceiverId == userId && !m.IsRead)
                .CountAsync();
        }
    }
}
