using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck d = new Deck();
            d.Print();
            d.Shuffle();
            d.Print();

            Player p = new Player("x");
            p.Draw(d);
            p.Draw(d);
            p.Draw(d);
            p.Draw(d);
            p.Draw(d);
            p.Print();
            p.Discard(0);
            p.Print();
        }
    }
}
