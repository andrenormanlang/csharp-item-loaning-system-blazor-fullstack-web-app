using ComicBooksLoanAppAPI.Models;

namespace ComicBooksLoanAppAPI.Repositories
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
        /// Gets top-rated lenders asynchronously.
        /// </summary>
        /// <param name="count">The number of top lenders to retrieve.</param>
        /// <returns>A collection of the top-rated lenders.</returns>
        Task<IEnumerable<User>> GetTopRatedAsync(int count = 10);

        /// <summary>
        /// Gets users with successful loans asynchronously.
        /// </summary>
        /// <returns>A collection of users sorted by loan count.</returns>
        Task<IEnumerable<User>> GetMostActiveAsync();
    }
}
