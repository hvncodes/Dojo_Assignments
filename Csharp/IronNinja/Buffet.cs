using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;
         
        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {   // Name, Calories, IsSpicy, IsSweet
                new Food("Pizza", 300, false, true),
                new Food("Burger", 100, false, false),
                new Food("Boba Ice Cream", 100, false, true),
                new Food("Steak", 150, false, false),
                new Drink("Ghost Chili Vodka", 100, true),
                new Drink("Apple Juice", 50, false),
                new Drink("Milk", 50, false),
                new Drink("Orange Juice", 50, false)
            };
        }
         
        public IConsumable Serve()
        {
            Random rng = new Random();
            return Menu[rng.Next(Menu.Count)];
        }
    }


}


