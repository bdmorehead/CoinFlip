﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int coin;
            string userGuess;
            Random rnd = new Random();
            // Query the user
            Console.Write("Enter your guess, Heads (H) or Tails(T): ");
                userGuess = Console.ReadLine();

            // Get a random number for the coin flip

            coin = rnd.Next(0, 2);

            if (coin == 0 && userGuess == "T")
            {
                Console.WriteLine("The coin flip was tails, you win");
            }
            if (coin == 1 && userGuess == "H")
            {
                Console.WriteLine("The coin flie was heads, you win");
            }
            else
            {
                if (coin == 0)
                {
                    Console.WriteLine("It was heads, you lose");
                }
                if (coin == 1)
                {
                    Console.WriteLine("It was tails, you lose");
                }

            }
        }
    }
}
