using System;
using System.Collections.Generic;

namespace IronNinja
{
    class SpiceHound : Ninja
    {
        public override bool IsFull {
            // provide override for IsFull (Full at 1200 Calories)
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            // adds calorie value to SpiceHound's total calorieIntake (-5 additional calories if the consumable item is "Spicy")
            // adds the randomly selected IConsumable object to SpiceHound's ConsumptionHistory list
            // calls the IConsumable object's GetInfo() method
            if (IsFull)
            {
                Console.WriteLine("SpiceHound is full!");
            }
            else
            {
                calorieIntake += item.Calories;
                if (item.IsSpicy)
                {
                    calorieIntake -= 5;
                }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}