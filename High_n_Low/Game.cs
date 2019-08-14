using System;
using System.Collections.Generic;
using System.Text;

namespace High_n_Low
{
   public class Game
    {
       // public Card DealtCard= new Card();

        public Card DrawCard()
        {
            Card aCard = new Card();
           
            return aCard;
        }
    public Card Compare (Card aCard, Card DealtCard)
        {
            if (aCard.Value == DealtCard.Value && aCard.SuitStr() == DealtCard.SuitStr())
            {
                Console.WriteLine("Drew Duplicate - redrawing");
                Card redrawCard = new Card();
                aCard = redrawCard;
            }
            return aCard;
        }
    public static void Play(Card playerCard,Card drawnCard)
        {
            if (playerCard.Value < drawnCard.Value)
                Console.WriteLine("Win");
            else if (playerCard.Value > drawnCard.Value)
                Console.WriteLine("Lose");
            else if (playerCard.Value == drawnCard.Value)
                Console.WriteLine("Draw");
        }
    }
}
