using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsAndDishes.Models
{
    public class Chef
    {
        public int ChefId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* 
        Foreign Keys and Navigation Properties for Relationships
        Navigation properties are null unless you use .Include / .ThenInclude
        */

        // Navigation Property: 1 Chef : Many Dishes
        public List<Dish> Dishes { get; set; }

        // Methods
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}