using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClubKey.Data.Entities.Models
{
    public class Owner
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required"),
         StringLength(25, MinimumLength = 3,
             ErrorMessage = "The username must be between 3 and 25 characters"),
         RegularExpression("^[a-z0-9_-]{3,25}$",
             ErrorMessage = "The username is in the wrong format")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required"),
         DataType(DataType.Password),
         StringLength(25, MinimumLength = 8,
             ErrorMessage = "The password must longer than 8 characters"),
         RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$",
             ErrorMessage = "Password must have minimum eight characters, at least one uppercase letter, one lowercase letter and one number")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Company personal identification number is required"),
         DataType(DataType.Password),
         StringLength(11, MinimumLength = 11,
             ErrorMessage = "The personal identification number must have 11 digits"),
         RegularExpression("^[0-9]*$",
             ErrorMessage = "Personal identification number must have 11 digits")]
        public string CompanyOib { get; set; }

        public ICollection<Club> Clubs { get; set; }
    }
}
