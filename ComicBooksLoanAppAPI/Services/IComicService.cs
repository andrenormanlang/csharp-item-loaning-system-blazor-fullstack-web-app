using ComicBooksLoanAppAPI.Models;

namespace ComicBooksLoanAppAPI.Services
{
    /// <summary>
    /// Service interface for comic-related business logic.
    /// Handles operations and queries related to comic books in the marketplace.
    /// </summary>
    public interface IComicService
    {
        /// <summary>
        /// Gets all available comics asynchronously.
        /// </summary>
        /// <returns>A collection of available comics.</returns>
        Task<IEnumerable<Comic>> GetAvailableComicsAsync();

        /// <summary>
        /// Gets a comic by ID asynchronously.
        /// </summary>
        /// <param name="id">The comic ID.</param>
        /// <returns>The comic if found, otherwise null.</returns>
        Task<Comic?> GetComicAsync(int id);

        /// <summary>
        /// Gets a user's comic collection asynchronously.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>A collection of comics owned by the user.</returns>
        Task<IEnumerable<Comic>> GetUserCollectionAsync(int userId);

        /// <summary>
        /// Adds a new comic to the marketplace asynchronously.
        /// </summary>
        /// <param name="comic">The comic to add.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentException">Thrown when the comic is invalid.</exception>
        Task AddComicAsync(Comic comic);

        /// <summary>
        /// Updates a comic asynchronously.
        /// </summary>
        /// <param name="comic">The comic to update.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentException">Thrown when the comic is invalid.</exception>
        Task UpdateComicAsync(Comic comic);

        /// <summary>
        /// Removes a comic from the marketplace asynchronously.
        /// </summary>
        /// <param name="id">The comic ID.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task RemoveComicAsync(int id);

        /// <summary>
        /// Searches for comics by title asynchronously.
        /// </summary>
        /// <param name="searchTerm">The search term.</param>
        /// <returns>A collection of matching comics.</returns>
        Task<IEnumerable<Comic>> SearchByTitleAsync(string searchTerm);

        /// <summary>
        /// Gets comics filtered by era asynchronously.
        /// </summary>
        /// <param name="era">The comic era.</param>
        /// <returns>A collection of comics from the specified era.</returns>
        Task<IEnumerable<Comic>> GetByEraAsync(string era);

        /// <summary>
        /// Gets comics filtered by condition grade asynchronously.
        /// </summary>
        /// <param name="grade">The condition grade.</param>
        /// <returns>A collection of comics with the specified grade.</returns>
        Task<IEnumerable<Comic>> GetByConditionAsync(string grade);

        /// <summary>
        /// Gets comics by character asynchronously.
        /// </summary>
        /// <param name="character">The character name.</param>
        /// <returns>A collection of comics featuring the character.</returns>
        Task<IEnumerable<Comic>> GetByCharacterAsync(string character);

        /// <summary>
        /// Gets comics by publisher asynchronously.
        /// </summary>
        /// <param name="publisher">The publisher name.</param>
        /// <returns>A collection of comics from the publisher.</returns>
        Task<IEnumerable<Comic>> GetByPublisherAsync(string publisher);
    }
}
