using System;
using System.ComponentModel.DataAnnotations;
namespace ChefsAndDishes.Models
{
    public class Dish
    {
        public int DishId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Name of Dish")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Range(1, 5, ErrorMessage = "must be at between 1 and 5.")]
        public int? Tastiness { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Range(0, Int32.MaxValue, ErrorMessage = "must be at least 0 calories.")]
        [Display(Name = "# of Calories")]
        public int? Calories { get; set; }

        [Required(ErrorMessage = "is required.")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* 
        Foreign Keys and Navigation Properties for Relationships
        Navigation properties are null unless you use .Include / .ThenInclude
        */
        // FK: 1 Chef : Many Dish
        public int ChefId { get; set; }

        // Navigation Property: 1 Chef : Many Dish
        public Chef Author { get; set; }
    }
}