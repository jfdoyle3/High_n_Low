using System;

namespace High_n_Low
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerCard = 14;
            int drawnCard = 2;

            Console.WriteLine("Player Card: {0}",playerCard);
            Console.WriteLine("Card Drawn: {0}", drawnCard);

            if ( playerCard < drawnCard)
                    Console.WriteLine("Win");
            else if(playerCard>drawnCard)
                    Console.WriteLine("Lose");
            else if(playerCard==drawnCard)
                    Console.WriteLine("Draw");



            
            
        }
    }
}
