using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {
        public List<Card> Cards;

        public Deck()
        {
            Reset();
        }

        public void Print()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card);
            }
        }

        public Card Deal()
        {
            if (Cards.Count == 0)
            {
                return null;
            }

            Card cardToDeal = Cards[Cards.Count - 1];
            Cards.RemoveAt(Cards.Count - 1);
            return cardToDeal;
        }

        public void Shuffle()
        {
            Random rng = new Random();

            for (int i = 0; i < Cards.Count; i++)
            {
                int rand = rng.Next(Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[rand];
                Cards[rand] = temp;
            }
        }

        public void Reset()
        {
            Cards = new List<Card>();
            string[] stringVals = new string[]
            {
                "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"
            };
            string[] stringSuits = new string[]
            {
                "Clubs", "Spades", "Hearts", "Diamonds"
            };
            for (int i = 1; i <= 13; i++) {
                foreach (string suit in stringSuits)
                {
                    Card c = new Card(stringVals[i-1], suit, i);
                    Cards.Add(c);
                }
            }
        }
    }
}
