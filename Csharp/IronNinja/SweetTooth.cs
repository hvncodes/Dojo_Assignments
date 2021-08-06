using System;
using System.Collections.Generic;

namespace IronNinja
{
    class SweetTooth : Ninja
    {
        public override bool IsFull {
            // provide override for IsFull (Full at 1500 Calories)
            get
            {
                if (calorieIntake > 1500)
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
        // provide override for Consume
        {
            if (IsFull)
            {
                Console.WriteLine("SweetTooth is full!");
            }
            else
            {
                calorieIntake += item.Calories;
                if (item.IsSweet)
                {
                    calorieIntake += 10;
                }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}