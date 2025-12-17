using ComicBooksLoanAppAPI.Models;

namespace ComicBooksLoanAppAPI.Services
{
    /// <summary>
    /// Interface for user authentication operations.
    /// </summary>
    public interface IAuthenticationService
    {
        /// <summary>
        /// Registers a new user.
        /// </summary>
        Task<(bool Success, string Message)> RegisterAsync(
            string email,
            string username,
            string fullName,
            string password,
            string city,
            string zipCode,
            string readingFocus,
            string description,
            string favoriteCharacters,
            string? biography,
            string? imageUrl);

        /// <summary>
        /// Authenticates a user and returns user object if successful.
        /// </summary>
        Task<(bool Success, User? User, string Message)> LoginAsync(string email, string password);
    }
}
