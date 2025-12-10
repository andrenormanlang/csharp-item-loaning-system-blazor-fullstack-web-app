using ComicBooksLoanAppAPI.Models;
using ComicBooksLoanAppAPI.Models.DTOs;
using ComicBooksLoanAppAPI.Repositories;

namespace ComicBooksLoanAppAPI.Services
{
    /// <summary>
    /// Service implementation for message-related business logic.
    /// </summary>
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Initializes a new instance of the MessageService class.
        /// </summary>
        public MessageService(IMessageRepository messageRepository, IUserRepository userRepository)
        {
            _messageRepository = messageRepository;
            _userRepository = userRepository;
        }

        /// <summary>
        /// Sends a message from one user to another.
        /// </summary>
        public async Task<Message> SendMessageAsync(int senderId, SendMessageDto dto)
        {
            // Validate users exist
            var sender = await _userRepository.GetByIdAsync(senderId);
            if (sender == null)
                throw new ArgumentException("Sender not found.");

            var receiver = await _userRepository.GetByIdAsync(dto.ReceiverId);
            if (receiver == null)
                throw new ArgumentException("Receiver not found.");

            var message = new Message
            {
                SenderId = senderId,
                ReceiverId = dto.ReceiverId,
                Subject = dto.Subject,
                Content = dto.Content,
                SentDate = DateTime.UtcNow,
                IsRead = false
            };

            await _messageRepository.AddAsync(message);
            await _messageRepository.SaveAsync(); // ADDED: Save changes to get the ID
            
            return message;
        }

        /// <summary>
        /// Gets all messages for a user (inbox + sent).
        /// </summary>
        public async Task<IEnumerable<MessageDto>> GetMessagesForUserAsync(int userId)
        {
            var messages = await _messageRepository.GetMessagesForUserAsync(userId);
            return messages.Select(MapToDto);
        }

        /// <summary>
        /// Gets conversation between two users.
        /// </summary>
        public async Task<IEnumerable<MessageDto>> GetConversationAsync(int userId1, int userId2)
        {
            var messages = await _messageRepository.GetConversationAsync(userId1, userId2);
            return messages.Select(MapToDto);
        }

        /// <summary>
        /// Gets unread messages for a user.
        /// </summary>
        public async Task<IEnumerable<MessageDto>> GetUnreadMessagesAsync(int userId)
        {
            var messages = await _messageRepository.GetUnreadMessagesAsync(userId);
            return messages.Select(MapToDto);
        }

        /// <summary>
        /// Marks a message as read.
        /// </summary>
        public async Task<bool> MarkAsReadAsync(int messageId, int userId)
        {
            var message = await _messageRepository.GetByIdAsync(messageId);
            if (message == null || message.ReceiverId != userId)
                return false;

            return await _messageRepository.MarkAsReadAsync(messageId);
        }

        /// <summary>
        /// Gets the count of unread messages for a user.
        /// </summary>
        public async Task<int> GetUnreadCountAsync(int userId)
        {
            return await _messageRepository.GetUnreadCountAsync(userId);
        }

        /// <summary>
        /// Gets conversation summaries (inbox view).
        /// </summary>
        public async Task<IEnumerable<ConversationDto>> GetConversationsAsync(int userId)
        {
            var messages = await _messageRepository.GetMessagesForUserAsync(userId);

            // Group by conversation partner
            var conversations = messages
                .GroupBy(m => m.SenderId == userId ? m.ReceiverId : m.SenderId)
                .Select(g =>
                {
                    var lastMessage = g.OrderByDescending(m => m.SentDate).First();
                    var otherUser = lastMessage.SenderId == userId ? lastMessage.Receiver : lastMessage.Sender;
                    var unreadCount = g.Count(m => m.ReceiverId == userId && !m.IsRead);

                    return new ConversationDto
                    {
                        OtherUserId = otherUser!.Id,
                        OtherUsername = otherUser.Username,
                        OtherFullName = otherUser.FullName,
                        OtherUserImageUrl = otherUser.ImageUrl,
                        LastMessagePreview = lastMessage.Content.Length > 100
                            ? lastMessage.Content.Substring(0, 100) + "..."
                            : lastMessage.Content,
                        LastMessageDate = lastMessage.SentDate,
                        UnreadCount = unreadCount
                    };
                })
                .OrderByDescending(c => c.LastMessageDate)
                .ToList();

            return conversations;
        }

        /// <summary>
        /// Maps a Message entity to a MessageDto.
        /// </summary>
        private MessageDto MapToDto(Message message)
        {
            return new MessageDto
            {
                Id = message.Id,
                SenderId = message.SenderId,
                SenderUsername = message.Sender?.Username ?? "",
                SenderFullName = message.Sender?.FullName ?? "",
                ReceiverId = message.ReceiverId,
                ReceiverUsername = message.Receiver?.Username ?? "",
                ReceiverFullName = message.Receiver?.FullName ?? "",
                Subject = message.Subject,
                Content = message.Content,
                SentDate = message.SentDate,
                IsRead = message.IsRead
            };
        }
    }
}
