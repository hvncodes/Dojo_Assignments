using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Wedder One")]
        public string WedderOne { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Wedder Two")]
        public string WedderTwo { get; set; }

        [Required(ErrorMessage = "is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime? WeddingDate { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Wedding Address")]
        public string Address { get; set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        
        // 1 : Many - FK & Navigational Property
        // One User creates many Weddings (Planner and Plans)
        public int UserId { get; set; }
        public User Planner { get; set; }

        // Many : Many - Property
        // One User can attend many Weddings, One Wedding can be attended by many Users.
        public List<UserWedding> UserWeddings { get; set; } // Guests -> Guests.Count
    }
}