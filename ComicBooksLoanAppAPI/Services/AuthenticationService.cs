using System.Security.Cryptography;
using System.Text;
using ComicBooksLoanAppAPI.Data;
using ComicBooksLoanAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ComicBooksLoanAppAPI.Services
{
    /// <summary>
    /// Service for handling user authentication (login, register, password verification).
    /// Uses PBKDF2 with SHA256 for password hashing.
    /// </summary>
    public class AuthenticationService : IAuthenticationService
    {
        private readonly comicbooksloanDbContext _context;
        private readonly ILogger<AuthenticationService> _logger;

        public AuthenticationService(comicbooksloanDbContext context, ILogger<AuthenticationService> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Registers a new user with email and password.
        /// </summary>
        public async Task<(bool Success, string Message)> RegisterAsync(string email, string username, string fullName, string password)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(email))
                    return (false, "Email is required.");

                if (string.IsNullOrWhiteSpace(username))
                    return (false, "Username is required.");

                if (string.IsNullOrWhiteSpace(fullName))
                    return (false, "Full name is required.");

                if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                    return (false, "Password must be at least 6 characters.");

                // Check if email already exists
                var existingEmailUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
                if (existingEmailUser != null)
                    return (false, "Email already registered.");

                // Check if username already exists
                var existingUsernameUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
                if (existingUsernameUser != null)
                    return (false, "Username already taken.");

                // Create new user
                var user = new User
                {
                    Email = email,
                    Username = username,
                    FullName = fullName,
                    PasswordHash = HashPassword(password),
                    MemberSince = DateTime.UtcNow,
                    IsVerified = false,
                    Description = "Comic enthusiast",
                    AverageRating = 0,
                    SuccessfulLoans = 0
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"User registered successfully: {username}");
                return (true, "Registration successful. Please log in.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error registering user");
                return (false, "An error occurred during registration.");
            }
        }

        /// <summary>
        /// Authenticates a user with email and password.
        /// </summary>
        public async Task<(bool Success, User? User, string Message)> LoginAsync(string email, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(email))
                    return (false, null, "Email is required.");

                if (string.IsNullOrWhiteSpace(password))
                    return (false, null, "Password is required.");

                // Find user by email
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
                if (user == null)
                {
                    _logger.LogWarning($"Login attempt with non-existent email: {email}");
                    return (false, null, "Invalid email or password.");
                }

                // Verify password
                if (!VerifyPassword(password, user.PasswordHash))
                {
                    _logger.LogWarning($"Failed login attempt for user: {user.Username}");
                    return (false, null, "Invalid email or password.");
                }

                _logger.LogInformation($"User logged in successfully: {user.Username}");
                return (true, user, "Login successful.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during login");
                return (false, null, "An error occurred during login.");
            }
        }

        /// <summary>
        /// Hashes a password using PBKDF2 with SHA256.
        /// </summary>
        private static string HashPassword(string password)
        {
            byte[] salt = new byte[20];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            using (var pdb = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
            {
                byte[] key = pdb.GetBytes(20);

                // Combine salt and hashed password
                byte[] hashBytes = new byte[40];
                Array.Copy(salt, 0, hashBytes, 0, 20);
                Array.Copy(key, 0, hashBytes, 20, 20);

                return Convert.ToBase64String(hashBytes);
            }
        }

        /// <summary>
        /// Verifies a password against a hash using PBKDF2 with SHA256.
        /// </summary>
        private static bool VerifyPassword(string password, string hash)
        {
            byte[] hashBytes = Convert.FromBase64String(hash);
            byte[] salt = new byte[20];
            Array.Copy(hashBytes, 0, salt, 0, 20);

            using (var pdb = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
            {
                byte[] key = pdb.GetBytes(20);
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 20] != key[i])
                        return false;
                }
            }

            return true;
        }
    }
}
