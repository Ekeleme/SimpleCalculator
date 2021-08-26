using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showCal = true;

            while (showCal)
            {
                Console.Clear();
                showCal = Calculator();
            }
        }

        private static bool Calculator()
        {
            Console.WriteLine("Hello, Welcome to Daniel's Arithmetic Program.");

            Console.Write("Please, type one of these signs to choose an operator " 
            + "\"+\", \"-\", \"/\", \"*\" \nOR type \"Quit\" to Exit application. ");

            string sign = Console.ReadLine();
            bool correctSign = true;

            while (correctSign)
            {
                if (sign == "+")
                {
                    Console.Write("Enter your first number... ");
                    int firstInput = Convert.ToInt32(Console.ReadLine());

                    Console.Write("What number should i add to "+ firstInput + "... ");
                    int secondInput = Convert.ToInt32(Console.ReadLine());

                    int result = firstInput + secondInput;
                    Console.WriteLine("Your answer is... " + result);
                    Console.Write("Press the \"Enter\" key to reset...");
                    correctSign = false;
                    Console.ReadLine();
                }
                else if (sign == "-")
                {
                    Console.Write("Enter your first number... ");
                    int firstInput = Convert.ToInt32(Console.ReadLine());

                    Console.Write("What number should i subtract from "+ firstInput + "... ");
                    int secondInput = Convert.ToInt32(Console.ReadLine());

                    int result = firstInput - secondInput;
                    Console.WriteLine("Your answer is... " + result);
                    Console.Write("Press the \"Enter\" key to reset...");
                    correctSign = false;
                    Console.ReadLine();
                }
                else if (sign == "/")
                {
                    Console.Write("Enter your first number... ");
                    int firstInput = Convert.ToInt32(Console.ReadLine());

                    Console.Write( firstInput + " divided by what... ");
                    int secondInput = Convert.ToInt32(Console.ReadLine());

                    int result = firstInput / secondInput;
                    Console.WriteLine("Your answer is... " + result);
                    Console.Write("Press the \"Enter\" key to reset...");
                    correctSign = false;
                    Console.ReadLine();
                }
                else if (sign == "*")
                {
                    Console.Write("Enter your first number... ");
                    int firstInput = Convert.ToInt32(Console.ReadLine());

                    Console.Write(firstInput + " multiplied by... ");
                    int secondInput = Convert.ToInt32(Console.ReadLine());

                    int result = firstInput * secondInput;
                    Console.WriteLine("Your answer is... " + result);
                    Console.Write("Press the \"Enter\" key to reset...");
                    correctSign = false;
                    Console.ReadLine();
                }
                else if (sign == "Quit")
                {
                    return false;
                }
                else if (sign == "quit")
                {
                    return false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("That's not a valid Operator!");
                    Console.Write("Try typing either one of these signs \"+\", " + "\"-\", \"/\", \"*\" Or type \"Quit\" to Exit application... ");
                    sign = Console.ReadLine();
                }
            }

            return true;
        }
    }
}
