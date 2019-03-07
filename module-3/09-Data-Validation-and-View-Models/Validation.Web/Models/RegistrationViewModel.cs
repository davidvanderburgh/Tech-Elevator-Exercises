using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "*")]
        [MaxLength(20, ErrorMessage = "First name must be less than 21 characters")]
        [Display(Name = "First name:")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*")]
        [MaxLength(20, ErrorMessage = "Last name must be less than 21 characters")]
        [Display(Name = "Last name:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email")]
        [Display(Name = "Email:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Confirm your email:")]
        [Compare("Email", ErrorMessage = "Email address does not match")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "*")]
        [MinLength(8, ErrorMessage = "Password minimum is 8 characters")]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [Required(ErrorMessage = "*")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [Display(Name = "Confirm your password:")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Date, ErrorMessage = "Not a valid date")]
        [Display(Name = "Birth day:")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "*")]
        [Range(1, 10, ErrorMessage = "The # of tickets must be between 1 and 10")]
        [Display(Name = "# of tickets:")]
        public int NumberOfTickets { get; set; }
    }
}