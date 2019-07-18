using System.ComponentModel.DataAnnotations;

namespace ClubKey.Data.Entities.Models
{
    public class Achievement
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required"),
         StringLength(25, MinimumLength = 3,
             ErrorMessage = "The name must longer than 3 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required"),
         StringLength(50, MinimumLength = 3,
             ErrorMessage = "Description must longer than 3 characters")]
        public string Description { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int RequiredPoints { get; set; }
    }
}
