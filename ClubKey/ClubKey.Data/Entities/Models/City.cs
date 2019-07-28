using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClubKey.Data.Entities.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required"),
         StringLength(25, MinimumLength = 3,
             ErrorMessage = "The name must be between 3 and 25 characters")]
        public string Name { get; set; }

        public ICollection<Club> Clubs { get; set; }
    }
}
