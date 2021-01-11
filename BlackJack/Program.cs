using System;

namespace BlackJack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int playerScore = 0, dealerScore = 0;
            bool isPlaying, playerWin;

            Console.WriteLine("--------------------");
            Console.WriteLine("WELCOME TO BLACKJACK");
            Console.WriteLine("--------------------\n");

            isPlaying = WantsToPlay();

            while (isPlaying)
            {
                playerWin = PlayHand();
                if (playerWin)
                {
                    playerScore++;
                }
                else
                {
                    dealerScore++;
                }

                isPlaying = WantsToPlay();
            }
        }

        private static bool WantsToPlay()
        {
            Console.WriteLine("Would you like to play Black Jack? Y/N");
            return Console.ReadKey().ToString().ToLower() == "y";
        }

        private static bool PlayHand()
        {
            Random rng = new Random();
            Console.WriteLine("Playing Hand");
            return false;
        }
    }
}