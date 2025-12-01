using Microsoft.EntityFrameworkCore;
using ComicBooksExchangeAppAPI.Data;
using ComicBooksExchangeAppAPI.Models;

namespace ComicBooksExchangeAppAPI.Repositories
{
    /// <summary>
    /// Specialized repository implementation for User operations.
    /// Provides advanced querying and filtering specific to user profiles and ratings.
    /// </summary>
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ComicBooksExchangeDbContext _context;

        /// <summary>
        /// Initializes a new instance of the UserRepository class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public UserRepository(ComicBooksExchangeDbContext context) : base(context)
        {
            _context = context;
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
                .Include(u => u.ExchangesInitiated)
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
                .Include(u => u.ExchangesInitiated)
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
                .Where(u => u.IsVerified)
                .Include(u => u.Comics)
                .OrderBy(u => u.FullName)
                .ToListAsync();
        }

        /// <summary>
        /// Gets users by collecting focus asynchronously.
        /// </summary>
        /// <param name="focus">The collecting focus area.</param>
        /// <returns>A collection of users with the specified collecting focus.</returns>
        public async Task<IEnumerable<User>> GetByCollectingFocusAsync(string focus)
        {
            return await _context.Users
                .Where(u => u.CollectingFocus.Contains(focus))
                .Include(u => u.Comics)
                .OrderByDescending(u => u.AverageRating)
                .ToListAsync();
        }

        /// <summary>
        /// Gets top-rated collectors asynchronously.
        /// </summary>
        /// <param name="count">The number of top collectors to retrieve.</param>
        /// <returns>A collection of the top-rated collectors.</returns>
        public async Task<IEnumerable<User>> GetTopRatedAsync(int count = 10)
        {
            return await _context.Users
                .Where(u => u.SuccessfulExchanges > 0)
                .Include(u => u.Comics)
                .OrderByDescending(u => u.AverageRating)
                .Take(count)
                .ToListAsync();
        }

        /// <summary>
        /// Gets users with successful exchanges asynchronously.
        /// </summary>
        /// <returns>A collection of users sorted by exchange count.</returns>
        public async Task<IEnumerable<User>> GetMostActiveAsync()
        {
            return await _context.Users
                .Where(u => u.SuccessfulExchanges > 0)
                .Include(u => u.Comics)
                .OrderByDescending(u => u.SuccessfulExchanges)
                .ToListAsync();
        }

        /// <summary>
        /// Gets users by location for local exchanges asynchronously.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <returns>A collection of users in the specified location.</returns>
        public async Task<IEnumerable<User>> GetByLocationAsync(string location)
        {
            return await _context.Users
                .Where(u => u.Location != null && u.Location.Contains(location))
                .Include(u => u.Comics)
                .OrderBy(u => u.FullName)
                .ToListAsync();
        }
    }
}
