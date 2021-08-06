using System;
using System.Collections.Generic;

namespace WizNinSam
{
    class Wizard : Human
    {
        public string Title;
        public Wizard(string name, string title) : base(name)
        {
            Title = title;
            Intelligence = 25;
            health = 50;
        }

        public override int Attack(Human target)
        {
            int dmg = 5 * Intelligence;
            health += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{Name} healed for {dmg} health!");
            return target.TakeDamage(dmg);
        }

        public int Heal(Human target)
        {
            return target.TakeDamage(-10 * Intelligence);
        }
    }
}