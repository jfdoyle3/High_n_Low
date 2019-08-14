using System;

namespace High_n_Low
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
              
            //Console.WriteLine("Player Card: {0} of {1}", playerCard.Value, playerCard.SuitStr());
            //Console.WriteLine("Card Drawn: {0} of {1}", drawnCard.Value, drawnCard.SuitStr());

            //Game.Play(playerCard, drawnCard);

            for (int index=0; index<5; index++)
            {
                Card card = new Card();
                Console.WriteLine("Card: {0} of {1}",card.Value, card.SuitStr());
            }



            
           
            
            //Console.WriteLine("Selected Card: {0} of {1}",selectCard.Value,selectCard.SuitStr());
        }
    }
}
