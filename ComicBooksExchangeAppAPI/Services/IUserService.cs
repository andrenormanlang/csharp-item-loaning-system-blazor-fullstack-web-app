using ComicBooksExchangeAppAPI.Models;

namespace ComicBooksExchangeAppAPI.Services
{
    /// <summary>
    /// Service interface for user-related business logic.
    /// Handles operations and queries related to user profiles and ratings.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Gets all users asynchronously.
        /// </summary>
        /// <returns>A collection of all users.</returns>
        Task<IEnumerable<User>> GetAllUsersAsync();

        /// <summary>
        /// Gets a user by ID asynchronously.
        /// </summary>
        /// <param name="id">The user ID.</param>
        /// <returns>The user if found, otherwise null.</returns>
        Task<User?> GetUserAsync(int id);

        /// <summary>
        /// Gets a user by username asynchronously.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>The user if found, otherwise null.</returns>
        Task<User?> GetUserByUsernameAsync(string username);

        /// <summary>
        /// Gets a user by email asynchronously.
        /// </summary>
        /// <param name="email">The email address.</param>
        /// <returns>The user if found, otherwise null.</returns>
        Task<User?> GetUserByEmailAsync(string email);

        /// <summary>
        /// Registers a new user asynchronously.
        /// </summary>
        /// <param name="user">The user to register.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentException">Thrown when the user data is invalid.</exception>
        Task RegisterUserAsync(User user);

        /// <summary>
        /// Updates a user's profile asynchronously.
        /// </summary>
        /// <param name="user">The user to update.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task UpdateUserAsync(User user);

        /// <summary>
        /// Gets verified users asynchronously.
        /// </summary>
        /// <returns>A collection of verified users.</returns>
        Task<IEnumerable<User>> GetVerifiedUsersAsync();

        /// <summary>
        /// Gets top-rated collectors asynchronously.
        /// </summary>
        /// <param name="count">The number of collectors to retrieve.</param>
        /// <returns>A collection of top-rated collectors.</returns>
        Task<IEnumerable<User>> GetTopRatedCollectorsAsync(int count = 10);

        /// <summary>
        /// Gets the most active collectors asynchronously.
        /// </summary>
        /// <returns>A collection of most active collectors.</returns>
        Task<IEnumerable<User>> GetMostActiveCollectorsAsync();

        /// <summary>
        /// Gets collectors by location asynchronously.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <returns>A collection of collectors in the location.</returns>
        Task<IEnumerable<User>> GetCollectorsByLocationAsync(string location);

        /// <summary>
        /// Gets collectors by collecting focus asynchronously.
        /// </summary>
        /// <param name="focus">The collecting focus.</param>
        /// <returns>A collection of collectors with the focus.</returns>
        Task<IEnumerable<User>> GetCollectorsByFocusAsync(string focus);

        /// <summary>
        /// Updates a user's rating based on reviews asynchronously.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task UpdateUserRatingAsync(int userId);

        /// <summary>
        /// Increments the successful exchange count for a user asynchronously.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task IncrementSuccessfulExchangesAsync(int userId);
    }
}
