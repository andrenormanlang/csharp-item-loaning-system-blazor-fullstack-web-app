using System.ComponentModel.DataAnnotations;
using ComicBooksExchangeAppAPI.Models;

namespace ComicBooksExchangeAppAPI.Validators
{
    /// <summary>
    /// Provides validation logic for domain entities.
    /// Enforces business rules and data integrity constraints.
    /// </summary>
    public static class EntityValidator
    {
        /// <summary>
        /// Valid condition grades for comics.
        /// </summary>
        public static readonly string[] ValidConditionGrades = 
        {
            "Mint", "Near Mint", "Very Fine", "Fine", "Very Good", "Good", "Fair", "Poor"
        };

        /// <summary>
        /// Valid comic eras.
        /// </summary>
        public static readonly string[] ValidEras = 
        {
            "Golden Age", "Silver Age", "Bronze Age", "Modern Age", "Contemporary"
        };

        /// <summary>
        /// Valid exchange statuses.
        /// </summary>
        public static readonly string[] ValidExchangeStatuses = 
        {
            "Pending", "Accepted", "Shipped", "Completed", "Cancelled", "Disputed"
        };

        /// <summary>
        /// Valid transaction statuses.
        /// </summary>
        public static readonly string[] ValidTransactionStatuses = 
        {
            "Pending", "InTransit", "Received", "Completed", "Disputed"
        };

        /// <summary>
        /// Validates a condition grade.
        /// </summary>
        /// <param name="grade">The condition grade to validate.</param>
        /// <returns>True if valid, otherwise false.</returns>
        public static bool IsValidConditionGrade(string grade)
        {
            return !string.IsNullOrWhiteSpace(grade) && ValidConditionGrades.Contains(grade);
        }

        /// <summary>
        /// Validates a comic era.
        /// </summary>
        /// <param name="era">The era to validate.</param>
        /// <returns>True if valid, otherwise false.</returns>
        public static bool IsValidEra(string era)
        {
            return !string.IsNullOrWhiteSpace(era) && ValidEras.Contains(era);
        }

        /// <summary>
        /// Validates an exchange status.
        /// </summary>
        /// <param name="status">The status to validate.</param>
        /// <returns>True if valid, otherwise false.</returns>
        public static bool IsValidExchangeStatus(string status)
        {
            return !string.IsNullOrWhiteSpace(status) && ValidExchangeStatuses.Contains(status);
        }

        /// <summary>
        /// Validates a transaction status.
        /// </summary>
        /// <param name="status">The status to validate.</param>
        /// <returns>True if valid, otherwise false.</returns>
        public static bool IsValidTransactionStatus(string status)
        {
            return !string.IsNullOrWhiteSpace(status) && ValidTransactionStatuses.Contains(status);
        }

        /// <summary>
        /// Validates an email address format.
        /// </summary>
        /// <param name="email">The email to validate.</param>
        /// <returns>True if valid format, otherwise false.</returns>
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Validates a rating value.
        /// </summary>
        /// <param name="rating">The rating to validate.</param>
        /// <returns>True if rating is between 1 and 5, otherwise false.</returns>
        public static bool IsValidRating(int rating)
        {
            return rating >= 1 && rating <= 5;
        }
    }
}
