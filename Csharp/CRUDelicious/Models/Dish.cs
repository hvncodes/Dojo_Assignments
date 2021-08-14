using System;
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
        [Display(Name = "Name of Dish")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
        [Display(Name = "Chef's Name")]
        public string Chef { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Range(1, 5, ErrorMessage = "must be at between 1 and 5.")]
        // [Display(Name = "Tastiness")]
        public int? Tastiness { get; set; }

        [Required(ErrorMessage = "is required.")]
        [Range(0, Int32.MaxValue, ErrorMessage = "must be at least 0 calories.")]
        [Display(Name = "# of Calories")]
        public int? Calories { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters.")]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}