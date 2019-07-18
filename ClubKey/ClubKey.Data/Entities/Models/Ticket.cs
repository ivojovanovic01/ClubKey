using System;
using System.ComponentModel.DataAnnotations;

namespace ClubKey.Data.Entities.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        [Range(double.Epsilon, double.MaxValue)]
        public double Price { get; set; }
    }
}
