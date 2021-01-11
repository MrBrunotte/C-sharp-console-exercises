using System;

namespace BishBosh
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            int num;
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("\n------------------");
                Console.WriteLine("THE BISH-BOSH GAME");
                Console.WriteLine("-------------------");
                Console.WriteLine("\nType a number between 15 - 100");
                num = int.Parse(Console.ReadLine());

                if (num < 15 || num > 100)
                    Console.WriteLine($"Invalid input! Your wrote {num} and it must be between 15 and 100.\n");
                else
                {
                    int[] intList = new int[num + 1];
                    for (int i = 1; i < intList.Length; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Bish-Bosch");
                        }
                        else if (i % 3 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Bish");
                        }
                        else if (i % 5 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Bosh");
                        }
                        else
                            Console.WriteLine(i);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\nYou wrote the number: {num}\n");
                }
                Console.WriteLine("Do you want to Exit? (y/n)");
                string choise = Console.ReadKey().ToString().ToLower();
                if (choise == "y")
                {
                    Console.WriteLine("\nType a number between 15 - 100");
                }
                if (choise == "n")
                {
                    isTrue = false;
                    Console.WriteLine("Thanks for playing, have a nice day!");
                    Environment.Exit(0);
                }
            }
        }
    }
}