using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Buffet b = new Buffet();
            // Food f = b.Serve();
            Ninja n = new Ninja();
            while (!n.IsFull)
            {
                Food f = b.Serve();
                Console.WriteLine($"The buffet has served {f.Name}!");
                n.Eat(f);
            }
            Console.WriteLine($"One last foodstuffs?");
            Food justOneMore = b.Serve();
            n.Eat(justOneMore);
        }
    }
}
