using Microsoft.AspNetCore.Mvc;
using ComicBooksExchangeAppAPI.Models.DTOs;
using ComicBooksExchangeAppAPI.Services;

namespace ComicBooksExchangeAppAPI.Controllers
{
    /// <summary>
    /// API controller for managing private messages between community members.
    /// Provides endpoints for sending messages, viewing conversations, and managing inbox.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly ILogger<MessagesController> _logger;

        /// <summary>
        /// Initializes a new instance of the MessagesController class.
        /// </summary>
        public MessagesController(IMessageService messageService, ILogger<MessagesController> _logger)
        {
            _messageService = messageService;
            this._logger = _logger;
        }

        /// <summary>
        /// Sends a new message to another member.
        /// </summary>
        /// <param name="senderId">The ID of the user sending the message.</param>
        /// <param name="dto">The message details.</param>
        /// <returns>The sent message.</returns>
        [HttpPost("send/{senderId}")]
        public async Task<ActionResult> SendMessage(int senderId, [FromBody] SendMessageDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var message = await _messageService.SendMessageAsync(senderId, dto);
                return Ok(new { messageId = message.Id, sentDate = message.SentDate });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending message");
                return StatusCode(500, "An error occurred while sending the message.");
            }
        }

        /// <summary>
        /// Gets all conversations for a user (inbox view).
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>List of conversation summaries.</returns>
        [HttpGet("conversations/{userId}")]
        public async Task<ActionResult<IEnumerable<ConversationDto>>> GetConversations(int userId)
        {
            try
            {
                var conversations = await _messageService.GetConversationsAsync(userId);
                return Ok(conversations);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving conversations for user {UserId}", userId);
                return StatusCode(500, "An error occurred while retrieving conversations.");
            }
        }

        /// <summary>
        /// Gets conversation messages between two users.
        /// </summary>
        /// <param name="userId1">First user ID (current user).</param>
        /// <param name="userId2">Second user ID (conversation partner).</param>
        /// <returns>List of messages in the conversation.</returns>
        [HttpGet("conversation/{userId1}/{userId2}")]
        public async Task<ActionResult<IEnumerable<MessageDto>>> GetConversation(int userId1, int userId2)
        {
            try
            {
                var messages = await _messageService.GetConversationAsync(userId1, userId2);
                return Ok(messages);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving conversation between {UserId1} and {UserId2}", userId1, userId2);
                return StatusCode(500, "An error occurred while retrieving the conversation.");
            }
        }

        /// <summary>
        /// Gets unread messages for a user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>List of unread messages.</returns>
        [HttpGet("unread/{userId}")]
        public async Task<ActionResult<IEnumerable<MessageDto>>> GetUnreadMessages(int userId)
        {
            try
            {
                var messages = await _messageService.GetUnreadMessagesAsync(userId);
                return Ok(messages);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving unread messages for user {UserId}", userId);
                return StatusCode(500, "An error occurred while retrieving unread messages.");
            }
        }

        /// <summary>
        /// Gets the count of unread messages for a user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>The unread message count.</returns>
        [HttpGet("unread/count/{userId}")]
        public async Task<ActionResult<int>> GetUnreadCount(int userId)
        {
            try
            {
                var count = await _messageService.GetUnreadCountAsync(userId);
                return Ok(new { count });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving unread count for user {UserId}", userId);
                return StatusCode(500, "An error occurred while retrieving the unread count.");
            }
        }

        /// <summary>
        /// Marks a message as read.
        /// </summary>
        /// <param name="messageId">The message ID.</param>
        /// <param name="userId">The user ID (must be the receiver).</param>
        /// <returns>Success status.</returns>
        [HttpPatch("{messageId}/mark-read/{userId}")]
        public async Task<ActionResult> MarkAsRead(int messageId, int userId)
        {
            try
            {
                var success = await _messageService.MarkAsReadAsync(messageId, userId);
                if (!success)
                    return NotFound("Message not found or unauthorized.");

                return Ok(new { message = "Message marked as read." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error marking message {MessageId} as read", messageId);
                return StatusCode(500, "An error occurred while marking the message as read.");
            }
        }
    }
}
