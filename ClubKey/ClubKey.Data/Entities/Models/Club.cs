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

        [Required(ErrorMessage = "Club city is required")]
        public City City { get; set; }

        [Required(ErrorMessage = "Event owner is required")]
        public Owner Owner { get; set; }
    }
}
