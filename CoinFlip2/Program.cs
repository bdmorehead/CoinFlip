using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip2
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            string coinDescription;

            Random rnd = new Random();
            // Query the user
            Console.Write("Enter your guess, Heads (H) or Tails(T): ");
            userGuess = Console.ReadLine();

            // Get a random number for the coin flip

            coin = rnd.Next(0, 2);
            if (coin == 1)
            {
                coinDescription = "Heads";
            }
            else
            {
                coinDescription = "Tails";
            }

            if ((coin == 0 && userGuess == "T") || (coin == 1 && userGuess == "H"))
            {
                Console.WriteLine($"The coin flip was {0}, you win", coinDescription);
            }

            else
            {
                if ((coin == 0) || (coin == 1))
                {
                    Console.WriteLine($"It was {coinDescription}, you lose");
                }
            }
        }
    }
}
