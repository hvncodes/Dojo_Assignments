using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
     
    // add a constructor
    public Ninja() // int calorie, List<Food> history
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }
    // add a public "getter" property called "IsFull"
    public bool IsFull
    {
        get
        {
            return calorieIntake > 1200;
        }
    }
    // build out the Eat method
    public void Eat(Food item)
    {
        if (IsFull)
        {
            Console.WriteLine("Ninja is full!");
            Console.WriteLine("------------");
        }
        else
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);

            string statement = $"That {item.Name} was ";
            if (item.IsSweet && item.IsSpicy)
                statement += "sweet and spicy!";
            else if (item.IsSweet)
                statement += "sweet!";
            else if (item.IsSpicy)
                statement += "spicy!";
            else
                statement += "mild.";
            Console.WriteLine(statement);
            Console.WriteLine($"Calories: +{item.Calories}, Total: {calorieIntake}");
            Console.WriteLine("------------");
        }
    }
}


}


