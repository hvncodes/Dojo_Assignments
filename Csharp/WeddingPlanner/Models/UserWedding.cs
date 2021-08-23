using System;
// using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class UserWedding
    {
        // Many : Many join table
        // One User can attend many Weddings, One Wedding can be attended by many Users.
        [Key]
        public int UserWeddingId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* 
        Foreign Keys and Navigation Properties for Relationships
        Navigation properties are null unless you use .Include / .ThenInclude
        */
        public int UserId { get; set; } // FK
        public int WeddingId { get; set; } // FK
        public User User { get; set; } // User's Nav. Prop.
        public Wedding Wedding { get; set; } // Wedding's Nav. Prop.
    }
}