using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab1.Models
{
    public class SignUpModel
    {
        [Required(ErrorMessage = "Please provide your name")]
        [RegularExpression(@"^[a-zA-Z.\- ]{3,50}$", ErrorMessage = "Invalid name It should 3 and 50 characters and contain only letters, dots, dashes, and spaces.")]

        public string Name { get; set; }

      

        [Required(ErrorMessage = "Please provide a username")]
        [RegularExpression(@"^[a-zA-Z0-9](?:[a-zA-Z0-9._]{3,5}[a-zA-Z0-9])?$", ErrorMessage = "Invalid username. It should be 5 to 7 characters long and can only contain letters, numbers, dots, underscores, but not starting or ending with a dot or underscore.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please provide an email")]
        [RegularExpression(@"^[0-9]{2}-[0-9]{5}-[1-3]@student\.aiub\.edu$", ErrorMessage = "Invalid email address. Please use the format xx-xxxxx-x@student.aiub.edu.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please provide a valid student ID")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]$", ErrorMessage = "Student ID should be in the format xx-xxxxx-x where 'x' is a number.")]
        public string StudentID { get; set; }

        [Required(ErrorMessage = "Please provide a password")]
        [RegularExpression(@"^(?=(.*[a-zA-Z]){2})(?=(.*\d))(?=(.*[\W]){2})[^\s]{8,}$", ErrorMessage = "Password must have at least 8 characters, at least 2 alphabets, 1 number, 2 special characters, and no spaces.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please provide a date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Age(ErrorMessage = "You must be at least 18 years old.")]
        public DateTime DateOfBirth { get; set; }
    }

    public class AgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            DateTime dateOfBirth = Convert.ToDateTime(value);

            
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now < dateOfBirth.AddYears(age)) age--;

            if (age < 18)
            {
                return new ValidationResult("You must be at least 18 years old.");
            }

            return ValidationResult.Success;
        }
    }

}