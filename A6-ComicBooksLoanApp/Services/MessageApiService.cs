using System.Net.Http.Json;

namespace A6_ComicBooksLoanApp.Services
{
    /// <summary>
    /// Service for handling message-related API calls.
    /// </summary>
    public class MessageApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<MessageApiService> _logger;

        public MessageApiService(HttpClient httpClient, ILogger<MessageApiService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        /// <summary>
        /// Sends a message to another user.
        /// </summary>
        public async Task<bool> SendMessageAsync(int senderId, SendMessageDto dto)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync($"api/messages/send/{senderId}", dto);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending message");
                return false;
            }
        }

        /// <summary>
        /// Gets all conversations for a user.
        /// </summary>
        public async Task<List<ConversationDto>> GetConversationsAsync(int userId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/messages/conversations/{userId}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<ConversationDto>>() ?? new List<ConversationDto>();
                }
                return new List<ConversationDto>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading conversations");
                return new List<ConversationDto>();
            }
        }

        /// <summary>
        /// Gets conversation messages between two users.
        /// </summary>
        public async Task<List<MessageDto>> GetConversationAsync(int userId1, int userId2)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/messages/conversation/{userId1}/{userId2}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<MessageDto>>() ?? new List<MessageDto>();
                }
                return new List<MessageDto>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading conversation messages");
                return new List<MessageDto>();
            }
        }

        /// <summary>
        /// Gets unread messages for a user.
        /// </summary>
        public async Task<List<MessageDto>> GetUnreadMessagesAsync(int userId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/messages/unread/{userId}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<MessageDto>>() ?? new List<MessageDto>();
                }
                return new List<MessageDto>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading unread messages");
                return new List<MessageDto>();
            }
        }

        /// <summary>
        /// Gets the count of unread messages for a user.
        /// </summary>
        public async Task<int> GetUnreadCountAsync(int userId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/messages/unread-count/{userId}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<int>();
                }
                return 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading unread count");
                return 0;
            }
        }

        /// <summary>
        /// Marks a message as read.
        /// </summary>
        public async Task<bool> MarkAsReadAsync(int messageId, int userId)
        {
            try
            {
                var response = await _httpClient.PatchAsync($"api/messages/{messageId}/mark-read/{userId}", null);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error marking message as read");
                return false;
            }
        }

        // Local DTO classes
        public class SendMessageDto
        {
            public int ReceiverId { get; set; }
            public string? Subject { get; set; }
            public string Content { get; set; } = string.Empty;
        }

        public class MessageDto
        {
            public int Id { get; set; }
            public int SenderId { get; set; }
            public string SenderUsername { get; set; } = string.Empty;
            public string SenderFullName { get; set; } = string.Empty;
            public int ReceiverId { get; set; }
            public string ReceiverUsername { get; set; } = string.Empty;
            public string ReceiverFullName { get; set; } = string.Empty;
            public string? Subject { get; set; }
            public string Content { get; set; } = string.Empty;
            public DateTime SentDate { get; set; }
            public bool IsRead { get; set; }
        }

        public class ConversationDto
        {
            public int OtherUserId { get; set; }
            public string OtherUsername { get; set; } = string.Empty;
            public string OtherFullName { get; set; } = string.Empty;
            public string? OtherUserImageUrl { get; set; }
            public string LastMessagePreview { get; set; } = string.Empty;
            public DateTime LastMessageDate { get; set; }
            public int UnreadCount { get; set; }
        }


    }
}
