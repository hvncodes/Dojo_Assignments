using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAndCategories.Models
{
    public class Product
    {
        [Key] // prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int ProductId { get; set; }

        [Required(ErrorMessage = "is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "is required")]
        public double? Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Many : Many - 1 Category can have many Products. 1 Product can be part of many Categories.
        public List<CategoryProduct> CategoryProducts { get; set; }
    }
}