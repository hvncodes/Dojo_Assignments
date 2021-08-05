using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Player
    {
        public string Name;
        public List<Card> Hand;

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public Card Draw(Deck d)
        {
            Card c = d.Deal();
            Hand.Add(c);
            Console.WriteLine($"{Name} drew {c}.");
            return c;
        }

        public Card Discard(int index)
        {
            if (Hand[index] == null)
            {
                return null;
            }
            else
            {
                Card c = Hand[index];
                Hand.Remove(c);
                Console.WriteLine($"{Name} discarded {c}.");
                return c;
            }
        }
        public void Print()
        {
            Console.WriteLine($"{Name}'s hand has:");
            foreach (Card c in Hand)
            {
                Console.WriteLine($"-{c}");
            }
        }
    }
}
