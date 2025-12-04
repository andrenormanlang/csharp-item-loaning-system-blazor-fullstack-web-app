using ComicBooksExchangeAppAPI.Models;
using ComicBooksExchangeAppAPI.Repositories;
using ComicBooksExchangeAppAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ComicBooksExchangeAppAPI.Services
{
    /// <summary>
    /// Service implementation for user-related business logic.
    /// Handles operations and queries related to user profiles and ratings.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ComicBooksExchangeDbContext _context;

        /// <summary>
        /// Initializes a new instance of the UserService class.
        /// </summary>
        /// <param name="userRepository">The user repository.</param>
        /// <param name="context">The database context.</param>
        public UserService(IUserRepository userRepository, ComicBooksExchangeDbContext context)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Gets all users asynchronously.
        /// </summary>
        /// <returns>A collection of all users.</returns>
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        /// <summary>
        /// Gets a user by ID asynchronously.
        /// </summary>
        /// <param name="id">The user ID.</param>
        /// <returns>The user if found, otherwise null.</returns>
        public async Task<User?> GetUserAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("User ID must be greater than 0.", nameof(id));
            }

            return await _userRepository.GetByIdAsync(id);
        }

        /// <summary>
        /// Gets a user by username asynchronously.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>The user if found, otherwise null.</returns>
        public async Task<User?> GetUserByUsernameAsync(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be empty.", nameof(username));
            }

            return await _userRepository.GetByUsernameAsync(username.Trim());
        }

        /// <summary>
        /// Gets a user by email asynchronously.
        /// </summary>
        /// <param name="email">The email address.</param>
        /// <returns>The user if found, otherwise null.</returns>
        public async Task<User?> GetUserByEmailAsync(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Email cannot be empty.", nameof(email));
            }

            return await _userRepository.GetByEmailAsync(email.Trim().ToLower());
        }

        /// <summary>
        /// Registers a new user asynchronously.
        /// </summary>
        /// <param name="user">The user to register.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentException">Thrown when the user data is invalid.</exception>
        public async Task RegisterUserAsync(User user)
        {
            ValidateUser(user);

            var existingUser = await _userRepository.GetByUsernameAsync(user.Username);
            if (existingUser != null)
            {
                throw new ArgumentException("Username already exists.", nameof(user.Username));
            }

            existingUser = await _userRepository.GetByEmailAsync(user.Email);
            if (existingUser != null)
            {
                throw new ArgumentException("Email already registered.", nameof(user.Email));
            }

            user.MemberSince = DateTime.UtcNow;
            user.AverageRating = 0;
            user.SuccessfulLoans = 0;

            await _userRepository.AddAsync(user);
            await _userRepository.SaveAsync();
        }

        /// <summary>
        /// Updates a user's profile asynchronously.
        /// </summary>
        /// <param name="user">The user to update.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task UpdateUserAsync(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (user.Id <= 0)
            {
                throw new ArgumentException("Valid user ID is required.", nameof(user.Id));
            }

            await _userRepository.UpdateAsync(user);
            await _userRepository.SaveAsync();
        }

        /// <summary>
        /// Gets verified users asynchronously.
        /// </summary>
        /// <returns>A collection of verified users.</returns>
        public async Task<IEnumerable<User>> GetVerifiedUsersAsync()
        {
            return await _userRepository.GetVerifiedUsersAsync();
        }

        /// <summary>
        /// Gets top-rated members asynchronously.
        /// </summary>
        /// <param name="count">The number of members to retrieve.</param>
        /// <returns>A collection of top-rated members.</returns>
        public async Task<IEnumerable<User>> GetTopRatedMembersAsync(int count = 10)
        {
            if (count <= 0)
            {
                throw new ArgumentException("Count must be greater than 0.", nameof(count));
            }

            return await _userRepository.GetTopRatedAsync(count);
        }

        /// <summary>
        /// Gets the most active members asynchronously.
        /// </summary>
        /// <returns>A collection of most active members.</returns>
        public async Task<IEnumerable<User>> GetMostActiveMembersAsync()
        {
            return await _userRepository.GetMostActiveAsync();
        }

        /// <summary>
        /// Updates a user's rating based on reviews asynchronously.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task UpdateUserRatingAsync(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("User ID must be greater than 0.", nameof(userId));
            }

            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
            {
                throw new ArgumentException("User not found.", nameof(userId));
            }

            if (user.ReviewsReceived.Count > 0)
            {
                user.AverageRating = (decimal)user.ReviewsReceived.Average(r => r.Rating);
            }

            await _userRepository.UpdateAsync(user);
            await _userRepository.SaveAsync();
        }

        /// <summary>
        /// Increments the successful exchange count for a user asynchronously.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task IncrementSuccessfulExchangesAsync(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("User ID must be greater than 0.", nameof(userId));
            }

            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
            {
                throw new ArgumentException("User not found.", nameof(userId));
            }

            user.SuccessfulLoans++;
            await _userRepository.UpdateAsync(user);
            await _userRepository.SaveAsync();
        }

        /// <summary>
        /// Checks if a user has any active loans (as borrower or lender).
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>True if user has active loans, otherwise false.</returns>
        public async Task<bool> HasActiveLoansAsync(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("User ID must be greater than 0.", nameof(userId));
            }

            var user = await _context.Users
                .Include(u => u.LoansAsBorrower)
                .Include(u => u.LoansAsLender)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentException("User not found.", nameof(userId));
            }

            // Check if user has any active loans (not returned) as borrower or lender
            var hasActiveBorrowerLoans = user.LoansAsBorrower.Any(l => l.Status == "Active" || l.Status == "Pending");
            var hasActiveLenderLoans = user.LoansAsLender.Any(l => l.Status == "Active" || l.Status == "Pending");

            return hasActiveBorrowerLoans || hasActiveLenderLoans;
        }

        /// <summary>
        /// Deletes a user account asynchronously.
        /// </summary>
        /// <param name="userId">The user ID to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="InvalidOperationException">Thrown when user has active loans.</exception>
        public async Task DeleteUserAsync(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("User ID must be greater than 0.", nameof(userId));
            }

            // Check for active loans first
            if (await HasActiveLoansAsync(userId))
            {
                throw new InvalidOperationException("Cannot delete account while you have active loans. Please return or receive all borrowed comics first.");
            }

            var user = await _context.Users
                .Include(u => u.Comics)
                .Include(u => u.ReviewsReceived)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new ArgumentException("User not found.", nameof(userId));
            }

            // Remove user's comics from the system
            _context.Comics.RemoveRange(user.Comics);

            // Remove reviews received by this user
            _context.Reviews.RemoveRange(user.ReviewsReceived);

            // Remove the user
            _context.Users.Remove(user);

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Validates a user entity for required fields.
        /// </summary>
        /// <param name="user">The user to validate.</param>
        /// <exception cref="ArgumentException">Thrown when the user is invalid.</exception>
        private void ValidateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (string.IsNullOrWhiteSpace(user.Username))
            {
                throw new ArgumentException("Username is required.", nameof(user.Username));
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {
                throw new ArgumentException("Email is required.", nameof(user.Email));
            }

            if (string.IsNullOrWhiteSpace(user.FullName))
            {
                throw new ArgumentException("Full name is required.", nameof(user.FullName));
            }
        }
    }
}
