using ComicBooksExchangeAppAPI.Models;

namespace ComicBooksExchangeAppAPI.Repositories
{
    /// <summary>
    /// Specialized repository interface for User operations.
    /// Provides advanced querying specific to user profiles and ratings.
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Gets a user by username asynchronously.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>The user if found, otherwise null.</returns>
        Task<User?> GetByUsernameAsync(string username);

        /// <summary>
        /// Gets a user by email asynchronously.
        /// </summary>
        /// <param name="email">The email address.</param>
        /// <returns>The user if found, otherwise null.</returns>
        Task<User?> GetByEmailAsync(string email);

        /// <summary>
        /// Gets verified users asynchronously.
        /// </summary>
        /// <returns>A collection of verified users.</returns>
        Task<IEnumerable<User>> GetVerifiedUsersAsync();

        /// <summary>
        /// Gets users by collecting focus asynchronously.
        /// </summary>
        /// <param name="focus">The collecting focus area.</param>
        /// <returns>A collection of users with the specified collecting focus.</returns>
        Task<IEnumerable<User>> GetByCollectingFocusAsync(string focus);

        /// <summary>
        /// Gets top-rated collectors asynchronously.
        /// </summary>
        /// <param name="count">The number of top collectors to retrieve.</param>
        /// <returns>A collection of the top-rated collectors.</returns>
        Task<IEnumerable<User>> GetTopRatedAsync(int count = 10);

        /// <summary>
        /// Gets users with successful exchanges asynchronously.
        /// </summary>
        /// <returns>A collection of users sorted by exchange count.</returns>
        Task<IEnumerable<User>> GetMostActiveAsync();

        /// <summary>
        /// Gets users by location for local exchanges asynchronously.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <returns>A collection of users in the specified location.</returns>
        Task<IEnumerable<User>> GetByLocationAsync(string location);
    }
}
