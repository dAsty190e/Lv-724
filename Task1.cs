using System;

namespace Task1
{
    internal class Task1
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            int a, b;

            Console.Write("Write value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The calculations are as folows:\n\ta + b = {a + b}\n\ta - b = {a - b}\n\ta * b = {a * b}\n\ta / b = {a / b}");

            Console.Write("How are you? ");
            string answer = Console.ReadLine();
            Console.WriteLine("You are {0}", answer);

            char firstChar, secondChar, thirdChar;

            Console.Write("Enter a first character: ");
            firstChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a second character: ");
            secondChar = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a third character: ");
            thirdChar = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("You've entered {0}, {1}, {2} characters", firstChar, secondChar, thirdChar);

            int positiveNum1, positiveNum2;

            Console.Write("Enter a first number: ");
            positiveNum1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            positiveNum2 = Convert.ToInt32(Console.ReadLine());

            if (positiveNum1 > 0 && positiveNum2 > 0)
            {
                Console.WriteLine("Both numbers are positive");
            }
            else
                Console.WriteLine("Number or numbers either negative or zero");

        }
    }
}
