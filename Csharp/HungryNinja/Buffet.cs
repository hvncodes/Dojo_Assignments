using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {   // Name, Calories, IsSpicy, IsSweet
            new Food("Example", 0, true, true),
            new Food("Pizza", 2000, false, true),
            new Food("Burger", 500, false, false),
            new Food("Cheetos", 200, true, false),
            new Food("Apple Juice", 100, false, true),
            new Food("Boba Ice Cream", 300, false, true),
            new Food("Steak", 400, false, false)
        };
    }
     
    public Food Serve()
    {
        Random rng = new Random();
        return Menu[rng.Next(Menu.Count)];
    }
}


}


