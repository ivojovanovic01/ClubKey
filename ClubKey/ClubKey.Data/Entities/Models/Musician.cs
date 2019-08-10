using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClubKey.Data.Entities.Models
{
    public class Musician
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
