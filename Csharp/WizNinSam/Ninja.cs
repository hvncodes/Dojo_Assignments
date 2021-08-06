using System;
using System.Collections.Generic;

namespace WizNinSam
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            Random rng = new Random();
            int extraDmg = 0;
            if (rng.Next(5) == 0) { // 0,1,2,3,4 -> 1 chance out of 5 possible
                extraDmg += 10;
            }
            int dmg = 5 * Dexterity + extraDmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.TakeDamage(dmg);
        }
        public int Steal(Human target)
        {
            int dmg = 5;
            health += dmg;
            Console.WriteLine($"{Name} mugged {target.Name} for {dmg} damage!");
            Console.WriteLine($"{Name} healed for {dmg} health!");
            return target.TakeDamage(dmg);
        }
    }
}