using System;

namespace IronNinja
{
    class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        
        // Implement a GetInfo Method
        public string GetInfo()
        {
            return $"{Name} (Drink).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: Always";
        }
        // Add a constructor method
        public Drink(string name, int cal, bool spicy)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = true;
        }
    }
}