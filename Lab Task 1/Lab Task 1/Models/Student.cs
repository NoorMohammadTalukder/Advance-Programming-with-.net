using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab_Task_1.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please provie Id")]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$", ErrorMessage = "ID Format is XX-XXXXX-X")]
        public string Id { get; set; }

        [RegularExpression(@"(?:[A-Z][a-zA-Z\. _]+)+[_a-zA-Z]", ErrorMessage = "Enter a valid Name")]
        //[RegularExpression(@"(?:[A-Z][a-zA-Z0-9\._]+)+[a-z0-9_]", ErrorMessage = "Enter a valid Name")]
        [Required(ErrorMessage = "Please provie Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provie Date of Birth")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Please provie Password")]
        [MaxLength(8, ErrorMessage = "Password must be Less than 8 Char")]
        public string Password { get; set; }

        //[NotMapped] // Does not effect with your database
        [Compare("Password")]
        public string confirmPassword { get; set; }

        [Required(ErrorMessage = "Please provie Email")]
        [EmailAddress(ErrorMessage = "Email format not matched ")]
        public string Email { get; set; }




    }
}