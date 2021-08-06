using System;
using System.Collections.Generic;

namespace WizNinSam
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }

        public override int Attack(Human target)
        {
            int targetRemainingHealth = base.Attack(target);
            if (targetRemainingHealth < 50)
            {
                Console.WriteLine($"{target.Name} was below 50 health and took a fatal hit!");
                return target.SpecialFinisher();
            }
            return targetRemainingHealth;
        }

        public void Meditate()
        {
            health = 200;
        }
    }
}