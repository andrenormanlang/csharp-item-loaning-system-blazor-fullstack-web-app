using Microsoft.EntityFrameworkCore;
using ComicBooksLoanAppAPI.Data;
using ComicBooksLoanAppAPI.Models;

namespace ComicBooksLoanAppAPI.Repositories
{
    /// <summary>
    /// Specialized repository implementation for User operations.
    /// Provides advanced querying and filtering specific to user profiles and ratings.
    /// </summary>
    public class UserRepository : Repository<User>, IUserRepository
    {
        /// <summary>
        /// Initializes a new instance of the UserRepository class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public UserRepository(comicbooksloanDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets a user by username asynchronously.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>The user if found, otherwise null.</returns>
        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await _context.Users
                .Include(u => u.Comics)
                .Include(u => u.LoanRequestsInitiated)
                .Include(u => u.ReviewsReceived)
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        /// <summary>
        /// Gets a user by email asynchronously.
        /// </summary>
        /// <param name="email">The email address.</param>
        /// <returns>The user if found, otherwise null.</returns>
        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _context.Users
                .Include(u => u.Comics)
                .Include(u => u.LoanRequestsInitiated)
                .Include(u => u.ReviewsReceived)
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        /// <summary>
        /// Gets verified users asynchronously.
        /// </summary>
        /// <returns>A collection of verified users.</returns>
        public async Task<IEnumerable<User>> GetVerifiedUsersAsync()
        {
            return await _context.Users
                .Where(u => u.IsVerified && u.ApprovalStatus == ApprovalStatus.Approved && u.Role != "Admin")
                .Include(u => u.Comics)
                .OrderBy(u => u.FullName)
                .ToListAsync();
        }

        /// <summary>
        /// Gets top-rated members asynchronously.
        /// </summary>
        /// <param name="count">The number of top members to retrieve.</param>
        /// <returns>A collection of the top-rated members.</returns>
        public async Task<IEnumerable<User>> GetTopRatedAsync(int count = 10)
        {
            return await _context.Users
                .Where(u => u.SuccessfulLoans > 0 && u.ApprovalStatus == ApprovalStatus.Approved && u.Role != "Admin")
                .Include(u => u.Comics)
                .OrderByDescending(u => u.AverageRating)
                .Take(count)
                .ToListAsync();
        }

        /// <summary>
        /// Gets users with successful loans asynchronously.
        /// </summary>
        /// <returns>A collection of users sorted by loan count.</returns>
        public async Task<IEnumerable<User>> GetMostActiveAsync()
        {
            return await _context.Users
                .Where(u => u.SuccessfulLoans > 0 && u.ApprovalStatus == ApprovalStatus.Approved && u.Role != "Admin")
                .Include(u => u.Comics)
                .OrderByDescending(u => u.SuccessfulLoans)
                .ToListAsync();
        }
    }
}
