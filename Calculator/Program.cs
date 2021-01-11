using System;

namespace Calculator
{
    internal class Program
    {
        private static int num1, num2, result;
        private static string typeOfCalculation;

        private static void Main(string[] args)
        {
            Calculate();
        }

        public static void Calculate()
        {
            Console.WriteLine("What type of calculation do you want to perform? (+,-,* or /");
            typeOfCalculation = Console.ReadLine().ToString();
            Console.Write("Type the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Type the second number: ");
            num2 = int.Parse(Console.ReadLine());
            if (typeOfCalculation == "+")
            {
                Addition(num1, num2);
            }
            else if (typeOfCalculation == "-")
            {
                Subtraction(num1, num2);
            }
            else if (typeOfCalculation == "*")
            {
                Multiplication(num1, num2);
            }
            else if (typeOfCalculation == "/")
            {
                Division(num1, num2);
            }
        }

        public static void Addition(int num1, int num2)
        {
            result = num1 + num2;
            ResultText(num1, num2);
        }
        private static void Subtraction(int num1, int num2)
        {
            result = num1 - num2;
            ResultText(num1, num2);
        }

        public static void Multiplication(int num1, int num2)
        {
            result = num1 * num2;
            ResultText(num1, num2);
        }

        public static void Division(int num1, int num2)
        {
            result = num1 / num2;
            ResultText(num1, num2);
        }
        private static void ResultText(int num1, int num2)
        {
            Console.WriteLine($"{num1} {typeOfCalculation} {num2} = {result}");
        }
    }
}