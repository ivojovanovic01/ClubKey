using System.ComponentModel.DataAnnotations;

namespace ClubKey.Data.Entities.Models
{
    public class Club
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required"),
         StringLength(25, MinimumLength = 3,
             ErrorMessage = "The name must be between 3 and 25 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        public City City { get; set; }

        public Owner Owner { get; set; }
    }
}
