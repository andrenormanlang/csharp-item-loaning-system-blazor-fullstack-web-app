using Microsoft.AspNetCore.Mvc;
using ComicBooksLoanAppAPI.Models;
using ComicBooksLoanAppAPI.Services;

namespace ComicBooksLoanAppAPI.Controllers
{
    /// <summary>
    /// API controller for managing comic books in the marketplace.
    /// Provides endpoints for browsing, searching, and managing comics.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ComicsController : ControllerBase
    {
        private readonly IComicService _comicService;
        private readonly ILogger<ComicsController> _logger;

        /// <summary>
        /// Initializes a new instance of the ComicsController class.
        /// </summary>
        /// <param name="comicService">The comic service.</param>
        /// <param name="logger">The logger.</param>
        public ComicsController(IComicService comicService, ILogger<ComicsController> logger)
        {
            _comicService = comicService ?? throw new ArgumentNullException(nameof(comicService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Gets all available comics.
        /// </summary>
        /// <returns>A collection of available comics.</returns>
        [HttpGet("available")]
        public async Task<ActionResult<IEnumerable<Comic>>> GetAvailableComics()
        {
            try
            {
                var comics = await _comicService.GetAvailableComicsAsync();
                return Ok(comics);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving available comics");
                return StatusCode(500, "An error occurred while retrieving comics.");
            }
        }

        /// <summary>
        /// Gets a comic by ID.
        /// </summary>
        /// <param name="id">The comic ID.</param>
        /// <returns>The comic if found.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Comic>> GetComic(int id)
        {
            try
            {
                var comic = await _comicService.GetComicAsync(id);
                if (comic == null)
                {
                    return NotFound();
                }

                return Ok(comic);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid comic ID: {id}", id);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving comic {id}", id);
                return StatusCode(500, "An error occurred while retrieving the comic.");
            }
        }

        /// <summary>
        /// Gets a user's comic collection.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <returns>A collection of comics owned by the user.</returns>
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<Comic>>> GetUserCollection(int userId)
        {
            try
            {
                var comics = await _comicService.GetUserCollectionAsync(userId);
                return Ok(comics);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid user ID: {userId}", userId);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving user collection for user {userId}", userId);
                return StatusCode(500, "An error occurred while retrieving the user's collection.");
            }
        }

        /// <summary>
        /// Adds a new comic to the marketplace.
        /// </summary>
        /// <param name="comic">The comic to add.</param>
        /// <returns>The created comic.</returns>
        [HttpPost]
        public async Task<ActionResult<Comic>> CreateComic([FromBody] Comic comic)
        {
            try
            {
                if (comic == null)
                {
                    return BadRequest("Comic cannot be null.");
                }

                await _comicService.AddComicAsync(comic);
                return CreatedAtAction(nameof(GetComic), new { id = comic.Id }, comic);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid comic data");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating comic");
                return StatusCode(500, "An error occurred while creating the comic.");
            }
        }

        /// <summary>
        /// Updates an existing comic.
        /// </summary>
        /// <param name="id">The comic ID.</param>
        /// <param name="comic">The updated comic data.</param>
        /// <returns>No content if successful.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateComic(int id, [FromBody] Comic comic)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("Invalid comic ID.");
                }

                if (comic == null)
                {
                    return BadRequest("Comic cannot be null.");
                }

                comic.Id = id;
                await _comicService.UpdateComicAsync(comic);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid update data for comic {id}", id);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating comic {id}", id);
                return StatusCode(500, "An error occurred while updating the comic.");
            }
        }

        /// <summary>
        /// Deletes a comic from the marketplace.
        /// </summary>
        /// <param name="id">The comic ID.</param>
        /// <returns>No content if successful.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComic(int id)
        {
            try
            {
                await _comicService.RemoveComicAsync(id);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid comic ID: {id}", id);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting comic {id}", id);
                return StatusCode(500, "An error occurred while deleting the comic.");
            }
        }

        /// <summary>
        /// Searches for comics by title.
        /// </summary>
        /// <param name="searchTerm">The search term.</param>
        /// <returns>A collection of matching comics.</returns>
        [HttpGet("search/title")]
        public async Task<ActionResult<IEnumerable<Comic>>> SearchByTitle([FromQuery] string searchTerm)
        {
            try
            {
                var comics = await _comicService.SearchByTitleAsync(searchTerm);
                return Ok(comics);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid search term");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching comics by title");
                return StatusCode(500, "An error occurred while searching for comics.");
            }
        }

        /// <summary>
        /// Gets comics by era.
        /// </summary>
        /// <param name="era">The comic era.</param>
        /// <returns>A collection of comics from the specified era.</returns>
        [HttpGet("filter/era")]
        public async Task<ActionResult<IEnumerable<Comic>>> GetByEra([FromQuery] string era)
        {
            try
            {
                var comics = await _comicService.GetByEraAsync(era);
                return Ok(comics);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid era");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving comics by era");
                return StatusCode(500, "An error occurred while retrieving comics by era.");
            }
        }

        /// <summary>
        /// Gets comics by condition grade.
        /// </summary>
        /// <param name="grade">The condition grade.</param>
        /// <returns>A collection of comics with the specified grade.</returns>
        [HttpGet("filter/condition")]
        public async Task<ActionResult<IEnumerable<Comic>>> GetByCondition([FromQuery] string grade)
        {
            try
            {
                var comics = await _comicService.GetByConditionAsync(grade);
                return Ok(comics);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid condition grade");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving comics by condition");
                return StatusCode(500, "An error occurred while retrieving comics by condition.");
            }
        }

        /// <summary>
        /// Gets comics by character.
        /// </summary>
        /// <param name="character">The character name.</param>
        /// <returns>A collection of comics featuring the character.</returns>
        [HttpGet("search/character")]
        public async Task<ActionResult<IEnumerable<Comic>>> GetByCharacter([FromQuery] string character)
        {
            try
            {
                var comics = await _comicService.GetByCharacterAsync(character);
                return Ok(comics);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid character search");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching comics by character");
                return StatusCode(500, "An error occurred while searching by character.");
            }
        }

        /// <summary>
        /// Gets comics by publisher.
        /// </summary>
        /// <param name="publisher">The publisher name.</param>
        /// <returns>A collection of comics from the publisher.</returns>
        [HttpGet("filter/publisher")]
        public async Task<ActionResult<IEnumerable<Comic>>> GetByPublisher([FromQuery] string publisher)
        {
            try
            {
                var comics = await _comicService.GetByPublisherAsync(publisher);
                return Ok(comics);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Invalid publisher search");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving comics by publisher");
                return StatusCode(500, "An error occurred while retrieving comics by publisher.");
            }
        }
    }
}
