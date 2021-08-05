using System;

namespace HumanOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Human John = new Human("John");
            Human David = new Human("David", 4, 4, 4, 100);
            Console.WriteLine(David.Health);
            John.Attack(David);
            Console.WriteLine(David.Health);
        }
    }
}
