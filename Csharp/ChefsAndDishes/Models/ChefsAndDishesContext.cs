using Microsoft.EntityFrameworkCore;
namespace ChefsAndDishes.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class ChefsAndDishesContext : DbContext 
    { 
        public ChefsAndDishesContext(DbContextOptions options) : base(options) { }
        // the "Monsters" table name will come from the DbSet variable name
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        
    }
}