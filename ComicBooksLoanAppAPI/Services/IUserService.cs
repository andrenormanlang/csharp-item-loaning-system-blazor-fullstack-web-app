using ComicBooksLoanAppAPI.Models;

namespace ComicBooksLoanAppAPI.Services
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
        /// Gets top-rated members asynchronously.
        /// </summary>
        /// <param name="count">The number of members to retrieve.</param>
        /// <returns>A collection of top-rated members.</returns>
        Task<IEnumerable<User>> GetTopRatedMembersAsync(int count = 10);

        /// <summary>
        /// Gets the most active members asynchronously.
        /// </summary>
        /// <returns>A collection of most active members.</returns>
        Task<IEnumerable<User>> GetMostActiveMembersAsync();

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

        /// <summary>
        /// Deletes a user account asynchronously.
        /// </summary>
        /// <param name="userId">The user ID to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="InvalidOperationException">Thrown when user has active loans.</exception>
        Task DeleteUserAsync(int userId);

        /// <summary>
        /// Checks if a user has any active loans (as borrower or lender).
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>True if user has active loans, otherwise false.</returns>
        Task<bool> HasActiveLoansAsync(int userId);
    }
}
