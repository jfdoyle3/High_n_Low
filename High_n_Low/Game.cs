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
    public bool Compare (Card aCard, Card DealtCard)
        { 
            return (aCard.Value == DealtCard.Value && aCard.SuitSym() == DealtCard.SuitSym());
        }
    public static void Play(string Guess, Card playerCard,Card drawnCard)
        {
            Console.WriteLine("Your Card: {0}{1}",playerCard.Value,playerCard.SuitSym());

        }
    public string Guess()
        {
            Console.WriteLine("Is your card going to be (H)igher, (L)ower, (Q)uit");
            string guess = Console.ReadLine();

            return guess;

        }
    }
}




//switch (Guess)
//{
//    case ((playerCard.Value < drawnCard.Value) && (Guess == "H" || Guess == "h" || Guess == "Higher" || Guess == "higher")):
//        Console.WriteLine("Lose");
//}
//if ((playerCard.Value < drawnCard.Value) && (Guess == "H" || Guess == "h" || Guess == "Higher" || Guess == "higher"))
//    Console.WriteLine("Lose");
//else if ((playerCard.Value > drawnCard.Value) && (Guess == "L" || Guess == "l" || Guess == "Lower" || Guess == "Lower"))
//    Console.WriteLine("Win");
//else if (playerCard.Value == drawnCard.Value)
//    Console.WriteLine("Draw");
