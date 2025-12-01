using System.ComponentModel.DataAnnotations;

namespace ComicBooksExchangeAppAPI.Validators
{
    /// <summary>
    /// Custom validation attribute for condition grades.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidConditionGradeAttribute : ValidationAttribute
    {
        /// <summary>
        /// Determines whether the specified value is valid.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>ValidationResult.Success if valid, otherwise an error message.</returns>
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Condition grade is required.");
            }

            var grade = value.ToString() ?? string.Empty;
            if (EntityValidator.IsValidConditionGrade(grade))
            {
                return ValidationResult.Success;
            }

            var validGrades = string.Join(", ", EntityValidator.ValidConditionGrades);
            return new ValidationResult($"Condition grade must be one of: {validGrades}");
        }
    }

    /// <summary>
    /// Custom validation attribute for comic eras.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidEraAttribute : ValidationAttribute
    {
        /// <summary>
        /// Determines whether the specified value is valid.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>ValidationResult.Success if valid, otherwise an error message.</returns>
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Era is required.");
            }

            var era = value.ToString() ?? string.Empty;
            if (EntityValidator.IsValidEra(era))
            {
                return ValidationResult.Success;
            }

            var validEras = string.Join(", ", EntityValidator.ValidEras);
            return new ValidationResult($"Era must be one of: {validEras}");
        }
    }

    /// <summary>
    /// Custom validation attribute for ratings (1-5 scale).
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidRatingAttribute : ValidationAttribute
    {
        /// <summary>
        /// Determines whether the specified value is valid.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>ValidationResult.Success if valid, otherwise an error message.</returns>
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Rating is required.");
            }

            if (int.TryParse(value.ToString(), out var rating))
            {
                if (EntityValidator.IsValidRating(rating))
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("Rating must be between 1 and 5.");
        }
    }

    /// <summary>
    /// Custom validation attribute for email addresses.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidEmailAttribute : ValidationAttribute
    {
        /// <summary>
        /// Determines whether the specified value is valid.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>ValidationResult.Success if valid, otherwise an error message.</returns>
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Email is required.");
            }

            var email = value.ToString() ?? string.Empty;
            if (EntityValidator.IsValidEmail(email))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid email address format.");
        }
    }
}
