using Microsoft.EntityFrameworkCore;
using ComicBooksLoanAppAPI.Data;
using ComicBooksLoanAppAPI.Models;

namespace ComicBooksLoanAppAPI.Repositories
{
    /// <summary>
    /// Specialized repository implementation for Comic operations.
    /// Provides advanced querying and filtering specific to comic books.
    /// </summary>
    public class ComicRepository : Repository<Comic>, IComicRepository
    {
        private new readonly comicbooksloanDbContext _context;

        /// <summary>
        /// Initializes a new instance of the ComicRepository class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public ComicRepository(comicbooksloanDbContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets available comics asynchronously.
        /// </summary>
        /// <returns>A collection of available comics.</returns>
        public async Task<IEnumerable<Comic>> GetAvailableAsync()
        {
            return await _context.Comics
                .Where(c => c.IsAvailable
                    && c.ApprovalStatus == ApprovalStatus.Approved
                    && c.Owner != null
                    && c.Owner.ApprovalStatus == ApprovalStatus.Approved)
                .Include(c => c.Owner)
                .OrderByDescending(c => c.DateListed)
                .ToListAsync();
        }

        /// <summary>
        /// Gets comics by owner ID asynchronously.
        /// </summary>
        /// <param name="ownerId">The owner's user ID.</param>
        /// <returns>A collection of comics owned by the specified user.</returns>
        public async Task<IEnumerable<Comic>> GetByOwnerIdAsync(int ownerId)
        {
            return await _context.Comics
                .Where(c => c.OwnerId == ownerId && c.ApprovalStatus == ApprovalStatus.Approved)
                .Include(c => c.Owner)
                .OrderBy(c => c.Title)
                .ToListAsync();
        }

        public async Task<IEnumerable<Comic>> GetByOwnerIdIncludingUnapprovedAsync(int ownerId)
        {
            return await _context.Comics
                .Where(c => c.OwnerId == ownerId)
                .Include(c => c.Owner)
                .OrderByDescending(c => c.DateListed)
                .ToListAsync();
        }

        /// <summary>
        /// Gets comics by era asynchronously.
        /// </summary>
        /// <param name="era">The comic era (e.g., "Bronze Age", "Silver Age").</param>
        /// <returns>A collection of comics from the specified era.</returns>
        public async Task<IEnumerable<Comic>> GetByEraAsync(string era)
        {
            return await _context.Comics
                .Where(c => c.Era == era && c.IsAvailable && c.ApprovalStatus == ApprovalStatus.Approved)
                .Include(c => c.Owner)
                .OrderBy(c => c.Title)
                .ToListAsync();
        }

        /// <summary>
        /// Gets comics by condition grade asynchronously.
        /// </summary>
        /// <param name="grade">The condition grade.</param>
        /// <returns>A collection of comics with the specified condition grade.</returns>
        public async Task<IEnumerable<Comic>> GetByConditionGradeAsync(string grade)
        {
            return await _context.Comics
                .Where(c => c.ConditionGrade == grade && c.IsAvailable && c.ApprovalStatus == ApprovalStatus.Approved)
                .Include(c => c.Owner)
                .OrderBy(c => c.Title)
                .ToListAsync();
        }

        /// <summary>
        /// Gets popular comics by era asynchronously.
        /// </summary>
        /// <returns>A collection of popular era comics.</returns>
        public async Task<IEnumerable<Comic>> GetPopularEraComicsAsync()
        {
            return await _context.Comics
                .Where(c => (c.Era == "Bronze Age" || c.Era == "Copper Age") && c.IsAvailable && c.ApprovalStatus == ApprovalStatus.Approved)
                .Include(c => c.Owner)
                .OrderBy(c => c.Title)
                .ToListAsync();
        }

        /// <summary>
        /// Gets comics by genre asynchronously.
        /// </summary>
        /// <param name="genre">The genre to search for.</param>
        /// <returns>A collection of comics matching the genre.</returns>
        public async Task<IEnumerable<Comic>> GetByGenreAsync(string genre)
        {
            return await _context.Comics
                .Where(c => c.Genre.Contains(genre) && c.IsAvailable && c.ApprovalStatus == ApprovalStatus.Approved)
                .Include(c => c.Owner)
                .OrderBy(c => c.Title)
                .ToListAsync();
        }

        /// <summary>
        /// Gets comics by title search asynchronously.
        /// </summary>
        /// <param name="searchTerm">The title search term.</param>
        /// <returns>A collection of comics matching the search term.</returns>
        public async Task<IEnumerable<Comic>> SearchByTitleAsync(string searchTerm)
        {
            return await _context.Comics
                .Where(c => c.Title.Contains(searchTerm) && c.IsAvailable && c.ApprovalStatus == ApprovalStatus.Approved)
                .Include(c => c.Owner)
                .OrderBy(c => c.Title)
                .ToListAsync();
        }

        /// <summary>
        /// Gets comics by publisher asynchronously.
        /// </summary>
        /// <param name="publisher">The publisher name.</param>
        /// <returns>A collection of comics from the specified publisher.</returns>
        public async Task<IEnumerable<Comic>> GetByPublisherAsync(string publisher)
        {
            return await _context.Comics
                .Where(c => c.Publisher == publisher && c.IsAvailable && c.ApprovalStatus == ApprovalStatus.Approved)
                .Include(c => c.Owner)
                .OrderBy(c => c.Title)
                .ToListAsync();
        }

        /// <summary>
        /// Gets comics by character search asynchronously.
        /// </summary>
        /// <param name="character">The character name or search term.</param>
        /// <returns>A collection of comics featuring the specified character.</returns>
        public async Task<IEnumerable<Comic>> GetByCharacterAsync(string character)
        {
            return await _context.Comics
                .Where(c => c.Characters.Contains(character) && c.IsAvailable && c.ApprovalStatus == ApprovalStatus.Approved)
                .Include(c => c.Owner)
                .OrderBy(c => c.Title)
                .ToListAsync();
        }
    }
}
