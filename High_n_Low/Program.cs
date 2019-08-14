using System;

namespace High_n_Low
{
    class Program
    {
        static void Main(string[] args)
        {

            Card deal = new Card();
            Game game = new Game();

            game.DrawCard();

            
            Console.WriteLine("Dealt: {0}{1}",deal.Value, deal.SuitStr());
              

          



            
           
            
           
        }
    }
}
