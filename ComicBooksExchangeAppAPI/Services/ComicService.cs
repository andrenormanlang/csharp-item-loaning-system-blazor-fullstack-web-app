using ComicBooksExchangeAppAPI.Models;
using ComicBooksExchangeAppAPI.Repositories;

namespace ComicBooksExchangeAppAPI.Services
{
    /// <summary>
    /// Service implementation for comic-related business logic.
    /// Handles operations and queries related to comic books in the marketplace.
    /// </summary>
    public class ComicService : IComicService
    {
        private readonly IComicRepository _comicRepository;

        /// <summary>
        /// Initializes a new instance of the ComicService class.
        /// </summary>
        /// <param name="comicRepository">The comic repository.</param>
        public ComicService(IComicRepository comicRepository)
        {
            _comicRepository = comicRepository ?? throw new ArgumentNullException(nameof(comicRepository));
        }

        /// <summary>
        /// Gets all available comics asynchronously.
        /// </summary>
        /// <returns>A collection of available comics.</returns>
        public async Task<IEnumerable<Comic>> GetAvailableComicsAsync()
        {
            return await _comicRepository.GetAvailableAsync();
        }

        /// <summary>
        /// Gets a comic by ID asynchronously.
        /// </summary>
        /// <param name="id">The comic ID.</param>
        /// <returns>The comic if found, otherwise null.</returns>
        public async Task<Comic?> GetComicAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Comic ID must be greater than 0.", nameof(id));
            }

            return await _comicRepository.GetByIdAsync(id);
        }

        /// <summary>
        /// Gets a user's comic collection asynchronously.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>A collection of comics owned by the user.</returns>
        public async Task<IEnumerable<Comic>> GetUserCollectionAsync(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("User ID must be greater than 0.", nameof(userId));
            }

            return await _comicRepository.GetByOwnerIdAsync(userId);
        }

        /// <summary>
        /// Adds a new comic to the marketplace asynchronously.
        /// </summary>
        /// <param name="comic">The comic to add.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentException">Thrown when the comic is invalid.</exception>
        public async Task AddComicAsync(Comic comic)
        {
            ValidateComic(comic);
            comic.DateListed = DateTime.UtcNow;
            await _comicRepository.AddAsync(comic);
            await _comicRepository.SaveAsync();
        }

        /// <summary>
        /// Updates a comic asynchronously.
        /// </summary>
        /// <param name="comic">The comic to update.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="ArgumentException">Thrown when the comic is invalid.</exception>
        public async Task UpdateComicAsync(Comic comic)
        {
            ValidateComic(comic);
            await _comicRepository.UpdateAsync(comic);
            await _comicRepository.SaveAsync();
        }

        /// <summary>
        /// Removes a comic from the marketplace asynchronously.
        /// </summary>
        /// <param name="id">The comic ID.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task RemoveComicAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Comic ID must be greater than 0.", nameof(id));
            }

            var comic = await _comicRepository.GetByIdAsync(id);
            if (comic != null)
            {
                await _comicRepository.DeleteAsync(comic);
                await _comicRepository.SaveAsync();
            }
        }

        /// <summary>
        /// Searches for comics by title asynchronously.
        /// </summary>
        /// <param name="searchTerm">The search term.</param>
        /// <returns>A collection of matching comics.</returns>
        public async Task<IEnumerable<Comic>> SearchByTitleAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Search term cannot be empty.", nameof(searchTerm));
            }

            return await _comicRepository.SearchByTitleAsync(searchTerm.Trim());
        }

        /// <summary>
        /// Gets comics filtered by era asynchronously.
        /// </summary>
        /// <param name="era">The comic era.</param>
        /// <returns>A collection of comics from the specified era.</returns>
        public async Task<IEnumerable<Comic>> GetByEraAsync(string era)
        {
            if (string.IsNullOrWhiteSpace(era))
            {
                throw new ArgumentException("Era cannot be empty.", nameof(era));
            }

            return await _comicRepository.GetByEraAsync(era.Trim());
        }

        /// <summary>
        /// Gets comics filtered by condition grade asynchronously.
        /// </summary>
        /// <param name="grade">The condition grade.</param>
        /// <returns>A collection of comics with the specified grade.</returns>
        public async Task<IEnumerable<Comic>> GetByConditionAsync(string grade)
        {
            if (string.IsNullOrWhiteSpace(grade))
            {
                throw new ArgumentException("Grade cannot be empty.", nameof(grade));
            }

            return await _comicRepository.GetByConditionGradeAsync(grade.Trim());
        }

        /// <summary>
        /// Gets key issue comics asynchronously.
        /// </summary>
        /// <returns>A collection of key issue comics.</returns>
        public async Task<IEnumerable<Comic>> GetKeyIssuesAsync()
        {
            return await _comicRepository.GetKeyIssuesAsync();
        }

        /// <summary>
        /// Gets professionally graded comics asynchronously.
        /// </summary>
        /// <returns>A collection of professionally graded comics.</returns>
        public async Task<IEnumerable<Comic>> GetProfessionallyGradedAsync()
        {
            return await _comicRepository.GetProfessionallyGradedAsync();
        }

        /// <summary>
        /// Gets comics by character asynchronously.
        /// </summary>
        /// <param name="character">The character name.</param>
        /// <returns>A collection of comics featuring the character.</returns>
        public async Task<IEnumerable<Comic>> GetByCharacterAsync(string character)
        {
            if (string.IsNullOrWhiteSpace(character))
            {
                throw new ArgumentException("Character name cannot be empty.", nameof(character));
            }

            return await _comicRepository.GetByCharacterAsync(character.Trim());
        }

        /// <summary>
        /// Gets comics by publisher asynchronously.
        /// </summary>
        /// <param name="publisher">The publisher name.</param>
        /// <returns>A collection of comics from the publisher.</returns>
        public async Task<IEnumerable<Comic>> GetByPublisherAsync(string publisher)
        {
            if (string.IsNullOrWhiteSpace(publisher))
            {
                throw new ArgumentException("Publisher name cannot be empty.", nameof(publisher));
            }

            return await _comicRepository.GetByPublisherAsync(publisher.Trim());
        }

        /// <summary>
        /// Validates a comic entity for required fields and business rules.
        /// </summary>
        /// <param name="comic">The comic to validate.</param>
        /// <exception cref="ArgumentException">Thrown when the comic is invalid.</exception>
        private void ValidateComic(Comic comic)
        {
            if (comic == null)
            {
                throw new ArgumentNullException(nameof(comic));
            }

            if (string.IsNullOrWhiteSpace(comic.Title))
            {
                throw new ArgumentException("Comic title is required.", nameof(comic.Title));
            }

            if (comic.OwnerId <= 0)
            {
                throw new ArgumentException("Valid owner ID is required.", nameof(comic.OwnerId));
            }

            if (string.IsNullOrWhiteSpace(comic.Publisher))
            {
                throw new ArgumentException("Publisher is required.", nameof(comic.Publisher));
            }

            if (string.IsNullOrWhiteSpace(comic.ConditionGrade))
            {
                throw new ArgumentException("Condition grade is required.", nameof(comic.ConditionGrade));
            }

            if (string.IsNullOrWhiteSpace(comic.Era))
            {
                throw new ArgumentException("Era is required.", nameof(comic.Era));
            }

            if (comic.EstimatedValue < 0)
            {
                throw new ArgumentException("Estimated value cannot be negative.", nameof(comic.EstimatedValue));
            }
        }
    }
}
