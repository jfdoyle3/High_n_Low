using System;
using System.Collections.Generic;
using System.Text;

namespace High_n_Low
{
    public class Card
    {
        public int Value;
        public int Suit;
        private string[] Suits = { "Spades", "Hearts", "Diamonds", "Clubs" };

        public Card()
        {
            Random newCard = new Random();
            Random newSuit = new Random();
            this.Value = newCard.Next(2,15);
            this.Suit = newSuit.Next(0, 4);
        }
        
        public Card(int Value, int Suit)
        {
            this.Value = Value;
            this.Suit = Suit;

        }

        public string SuitStr()
        {

            return this.Suits[this.Suit];
        }
    }
}
