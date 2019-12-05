using System;

namespace High_n_Low
{
    class Program
    {
        static void Main(string[] args)
        {
                Game game = new Game();
                Card deal = new Card();
                Card player = new Card();

                if (game.Compare(player, deal) == true)
                {
                    Card redraw = new Card();
                    player = redraw;
                }

                Console.WriteLine("Dealt:  {0}{1}", deal.Value, deal.SuitSym());

            string guess=game.Guess();

            Game.Play(guess, player, deal);
         
        }
    }
}
