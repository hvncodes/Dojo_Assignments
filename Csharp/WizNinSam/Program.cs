using System;

namespace WizNinSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------");
            Wizard w = new Wizard("Jon", "The Wiz");
            // Console.WriteLine($"{w.Name} {w.Title} has {w.Intelligence} INT.");
            // Wizard w = new Wizard("Wiz");
            Ninja n = new Ninja("Nin");
            Samurai s = new Samurai("Sam");
            s.Attack(n);
            s.Attack(n);
            s.Attack(n);
            s.Attack(n);
            s.Attack(n);
            s.Attack(n);
            Console.WriteLine("-------------");
            w.Attack(n);
            n.Attack(w);
            w.Heal(w);
            n.Steal(w);
            Console.WriteLine("-------------");
        }
    }
}
