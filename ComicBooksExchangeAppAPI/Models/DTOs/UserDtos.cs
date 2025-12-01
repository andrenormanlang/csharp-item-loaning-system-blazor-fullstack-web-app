using ComicBooksExchangeAppAPI.Validators;
using System.ComponentModel.DataAnnotations;

namespace ComicBooksExchangeAppAPI.Models.DTOs
{
    /// <summary>
    /// Data Transfer Object for registering a new user.
    /// Used for user registration API requests.
    /// </summary>
    public class RegisterUserDto
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters.")]
        [RegularExpression(@"^[a-zA-Z0-9_-]+$", ErrorMessage = "Username can only contain letters, numbers, underscores, and hyphens.")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full name must be between 2 and 100 characters.")]
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the collecting focus area.
        /// </summary>
        [Required(ErrorMessage = "Collecting focus is required.")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Collecting focus must be between 2 and 200 characters.")]
        public string CollectingFocus { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the preferred eras.
        /// </summary>
        [StringLength(500, ErrorMessage = "Preferred eras cannot exceed 500 characters.")]
        public string PreferredEras { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the favorite characters.
        /// </summary>
        [StringLength(500, ErrorMessage = "Favorite characters cannot exceed 500 characters.")]
        public string FavoriteCharacters { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's biography.
        /// </summary>
        [StringLength(1000, ErrorMessage = "Biography cannot exceed 1000 characters.")]
        public string? Biography { get; set; }

        /// <summary>
        /// Gets or sets the preferred exchange method.
        /// </summary>
        [Required(ErrorMessage = "Preferred exchange method is required.")]
        public string PreferredExchangeMethod { get; set; } = "Mail";

        /// <summary>
        /// Gets or sets the user's location.
        /// </summary>
        [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters.")]
        public string? Location { get; set; }

        /// <summary>
        /// Gets or sets the trade preferences.
        /// </summary>
        [StringLength(1000, ErrorMessage = "Trade preferences cannot exceed 1000 characters.")]
        public string? TradePreferences { get; set; }
    }

    /// <summary>
    /// Data Transfer Object for updating a user profile.
    /// Used for user profile update API requests.
    /// </summary>
    public class UpdateUserDto
    {
        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full name must be between 2 and 100 characters.")]
        public string? FullName { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the collecting focus area.
        /// </summary>
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Collecting focus must be between 2 and 200 characters.")]
        public string? CollectingFocus { get; set; }

        /// <summary>
        /// Gets or sets the preferred eras.
        /// </summary>
        [StringLength(500, ErrorMessage = "Preferred eras cannot exceed 500 characters.")]
        public string? PreferredEras { get; set; }

        /// <summary>
        /// Gets or sets the favorite characters.
        /// </summary>
        [StringLength(500, ErrorMessage = "Favorite characters cannot exceed 500 characters.")]
        public string? FavoriteCharacters { get; set; }

        /// <summary>
        /// Gets or sets the user's biography.
        /// </summary>
        [StringLength(1000, ErrorMessage = "Biography cannot exceed 1000 characters.")]
        public string? Biography { get; set; }

        /// <summary>
        /// Gets or sets the preferred exchange method.
        /// </summary>
        public string? PreferredExchangeMethod { get; set; }

        /// <summary>
        /// Gets or sets the user's location.
        /// </summary>
        [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters.")]
        public string? Location { get; set; }

        /// <summary>
        /// Gets or sets the trade preferences.
        /// </summary>
        [StringLength(1000, ErrorMessage = "Trade preferences cannot exceed 1000 characters.")]
        public string? TradePreferences { get; set; }
    }

    /// <summary>
    /// Data Transfer Object for displaying user information.
    /// Used for API responses.
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collecting focus area.
        /// </summary>
        public string CollectingFocus { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the preferred eras.
        /// </summary>
        public string PreferredEras { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the favorite characters.
        /// </summary>
        public string FavoriteCharacters { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user's biography.
        /// </summary>
        public string? Biography { get; set; }

        /// <summary>
        /// Gets or sets the successful exchange count.
        /// </summary>
        public int SuccessfulExchanges { get; set; }

        /// <summary>
        /// Gets or sets the average rating.
        /// </summary>
        public decimal AverageRating { get; set; }

        /// <summary>
        /// Gets or sets the member since date.
        /// </summary>
        public DateTime MemberSince { get; set; }

        /// <summary>
        /// Gets or sets whether the user is verified.
        /// </summary>
        public bool IsVerified { get; set; }

        /// <summary>
        /// Gets or sets the preferred exchange method.
        /// </summary>
        public string PreferredExchangeMethod { get; set; } = "Mail";

        /// <summary>
        /// Gets or sets the user's location.
        /// </summary>
        public string? Location { get; set; }

        /// <summary>
        /// Gets or sets the trade preferences.
        /// </summary>
        public string? TradePreferences { get; set; }

        /// <summary>
        /// Gets or sets the number of comics in collection.
        /// </summary>
        public int ComicsCount { get; set; }
    }
}
