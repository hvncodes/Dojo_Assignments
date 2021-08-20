using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAndCategories.Models
{
    public class CategoryProduct
    {
        // Many to Many 'through' / 'join' table. 
        // 1 Product can have many Categories, 1 Category be part of Many Products
        [Key] // primary key, [Key] is not needed if named with pattern: ModelNameId
        public int CategoryProductId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        /* 
        Foreign Keys and Navigation Properties for Relationships
        Navigation properties are null unless you use .Include / .ThenInclude
        */
        public int ProductId { get; set; } // FK
        public Product Product { get; set; }
        public int CategoryId { get; set; } // Fk
        public Category Category { get; set; }
    }
}