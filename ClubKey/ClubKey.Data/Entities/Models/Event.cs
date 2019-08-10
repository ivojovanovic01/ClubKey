using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ClubKey.Data.Enums;

namespace ClubKey.Data.Entities.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required"),
         StringLength(50, MinimumLength = 3,
             ErrorMessage = "The name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required"),
         Range(double.Epsilon, double.MaxValue)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Description is required"),
         StringLength(200, MinimumLength = 3,
             ErrorMessage = "The description must be between 3 and 200 characters")]
        public string Description { get; set; }
        public EventHashtag Hashtag { get; set; }

        [Required, 
         DataType(DataType.DateTime, ErrorMessage = "Start time must be in DateTime format")]
        public DateTime StartTime { get; set; }

        [Required,
         DataType(DataType.DateTime, ErrorMessage = "Finish time must be in DateTime format")]
        public DateTime FinishTime { get; set; }

        public Club Club { get; set; }
        public Musician Musician { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
