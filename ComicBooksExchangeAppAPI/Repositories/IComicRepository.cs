using ComicBooksExchangeAppAPI.Models;

namespace ComicBooksExchangeAppAPI.Repositories
{
    /// <summary>
    /// Specialized repository interface for Comic operations.
    /// Provides advanced querying specific to comics such as filtering by era, grade, and key issues.
    /// </summary>
    public interface IComicRepository : IRepository<Comic>
    {
        /// <summary>
        /// Gets available comics asynchronously.
        /// </summary>
        /// <returns>A collection of available comics.</returns>
        Task<IEnumerable<Comic>> GetAvailableAsync();

        /// <summary>
        /// Gets comics by owner ID asynchronously.
        /// </summary>
        /// <param name="ownerId">The owner's user ID.</param>
        /// <returns>A collection of comics owned by the specified user.</returns>
        Task<IEnumerable<Comic>> GetByOwnerIdAsync(int ownerId);

        /// <summary>
        /// Gets comics by era asynchronously.
        /// </summary>
        /// <param name="era">The comic era (e.g., "Bronze Age", "Silver Age").</param>
        /// <returns>A collection of comics from the specified era.</returns>
        Task<IEnumerable<Comic>> GetByEraAsync(string era);

        /// <summary>
        /// Gets comics by condition grade asynchronously.
        /// </summary>
        /// <param name="grade">The condition grade.</param>
        /// <returns>A collection of comics with the specified condition grade.</returns>
        Task<IEnumerable<Comic>> GetByConditionGradeAsync(string grade);

        /// <summary>
        /// Gets key issue comics asynchronously.
        /// </summary>
        /// <returns>A collection of key issue comics.</returns>
        Task<IEnumerable<Comic>> GetKeyIssuesAsync();

        /// <summary>
        /// Gets professionally graded comics asynchronously.
        /// </summary>
        /// <returns>A collection of professionally graded comics.</returns>
        Task<IEnumerable<Comic>> GetProfessionallyGradedAsync();

        /// <summary>
        /// Gets comics by title search asynchronously.
        /// </summary>
        /// <param name="searchTerm">The title search term.</param>
        /// <returns>A collection of comics matching the search term.</returns>
        Task<IEnumerable<Comic>> SearchByTitleAsync(string searchTerm);

        /// <summary>
        /// Gets comics by publisher asynchronously.
        /// </summary>
        /// <param name="publisher">The publisher name.</param>
        /// <returns>A collection of comics from the specified publisher.</returns>
        Task<IEnumerable<Comic>> GetByPublisherAsync(string publisher);

        /// <summary>
        /// Gets comics by character search asynchronously.
        /// </summary>
        /// <param name="character">The character name or search term.</param>
        /// <returns>A collection of comics featuring the specified character.</returns>
        Task<IEnumerable<Comic>> GetByCharacterAsync(string character);
    }
}
