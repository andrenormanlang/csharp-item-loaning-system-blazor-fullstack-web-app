using ComicBooksExchangeAppAPI.Models;
using ComicBooksExchangeAppAPI.Repositories;

namespace ComicBooksExchangeAppAPI.Services
{
    /// <summary>
    /// Service implementation for user-related business logic.
    /// Handles operations and queries related to user profiles and ratings.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Initializes a new instance of the UserService class.
        /// </summary>
        /// <param name="userRepository">The user repository.</param>
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
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
            user.SuccessfulExchanges = 0;

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
        /// Gets top-rated collectors asynchronously.
        /// </summary>
        /// <param name="count">The number of collectors to retrieve.</param>
        /// <returns>A collection of top-rated collectors.</returns>
        public async Task<IEnumerable<User>> GetTopRatedCollectorsAsync(int count = 10)
        {
            if (count <= 0)
            {
                throw new ArgumentException("Count must be greater than 0.", nameof(count));
            }

            return await _userRepository.GetTopRatedAsync(count);
        }

        /// <summary>
        /// Gets the most active collectors asynchronously.
        /// </summary>
        /// <returns>A collection of most active collectors.</returns>
        public async Task<IEnumerable<User>> GetMostActiveCollectorsAsync()
        {
            return await _userRepository.GetMostActiveAsync();
        }

        /// <summary>
        /// Gets collectors by location asynchronously.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <returns>A collection of collectors in the location.</returns>
        public async Task<IEnumerable<User>> GetCollectorsByLocationAsync(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
            {
                throw new ArgumentException("Location cannot be empty.", nameof(location));
            }

            return await _userRepository.GetByLocationAsync(location.Trim());
        }

        /// <summary>
        /// Gets collectors by collecting focus asynchronously.
        /// </summary>
        /// <param name="focus">The collecting focus.</param>
        /// <returns>A collection of collectors with the focus.</returns>
        public async Task<IEnumerable<User>> GetCollectorsByFocusAsync(string focus)
        {
            if (string.IsNullOrWhiteSpace(focus))
            {
                throw new ArgumentException("Focus cannot be empty.", nameof(focus));
            }

            return await _userRepository.GetByCollectingFocusAsync(focus.Trim());
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

            user.SuccessfulExchanges++;
            await _userRepository.UpdateAsync(user);
            await _userRepository.SaveAsync();
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

            if (string.IsNullOrWhiteSpace(user.CollectingFocus))
            {
                throw new ArgumentException("Collecting focus is required.", nameof(user.CollectingFocus));
            }
        }
    }
}
