using System;
using System.Collections.Generic;
using System.Linq;

namespace Classwork_3
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //      #1

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            if (a < b && a != 0 && b != 0)
            {
                
                for (int i = a; i <= b; i++)
                {
                    if (i % 3 == 0)
                    {
                        count++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Went something wrong!!!" + "\n"
                    + "Check data: ");
            }

            Console.WriteLine("Times divided on 3: " + count);

            ////      #2

            int n, sum = 0, m;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);

            //      #3

            Console.WriteLine("Choose the drink" + "\n" +
                             "1 - Coffee" + "\n" +
                             "2 - Tea" + "\n" +
                             "3 = Juice" + "\n" +
                             "4 - Water");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "1": Console.WriteLine("Coffee is 5$"); break;
                case "2": Console.WriteLine("Tea is 3$"); break;
                case "3": Console.WriteLine("Juice is 4$"); break;
                case "4": Console.WriteLine("Water is 1$"); break;
                default: Console.WriteLine("Enter another value: "); break;

            }

            //      #4

            string[] answer = new string[10];


            int ans = Convert.ToInt32(answer);

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = Console.ReadLine();
            }

            //      #5

            int a;
            Console.WriteLine("Enter the year");
            a = int.Parse(Console.ReadLine());
            {
                if ((a % 4) == 0)
                    Console.WriteLine("It's a leap year.");
                else
                    Console.WriteLine("It's not a leap year.");
            }

            Console.ReadLine();

            // #6

            Console.Write("Enter the number : ");
            var numberOf = Console.ReadLine()!;

            int n = 0;
            foreach (var numberN in numberOf)
            {
                n += int.Parse(numberN.ToString());
            }
            Console.WriteLine(n);

            ////      #7

            Console.Write($"Odd numbers : ");
            foreach (var numUser in numberOf)
            {
                if (numUser % 2 == 0)
                {
                    Console.Write($"{numUser} ");
                }
            }

            Console.Write($"\nEven numbers : ");
            foreach (var numUser in numberOf)
            {
                if (numUser % 2 != 0)
                {
                    Console.Write($"{numUser} ");
                }
            }

            ///         HOMEWORK        ///

            //      #1.1        for

            Console.WriteLine("Enter the string: ");
            string str = (Console.ReadLine());

            int i_counter = 0;
            int a_counter = 0;
            int e_counter = 0;
            int o_counter = 0;
            int counter;


            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == 'i')
                {
                    i_counter++;
                }
                else if (str[i] == 'a')
                {
                    a_counter++;
                }
                else if (str[i] == 'e')
                {
                    e_counter++;
                }
                else if (str[i] == 'o')
                {
                    o_counter++;
                }
            }

            ///         HOMEWORK        ///

            //      #1.2      foreach  

            Console.WriteLine("Enter the string: ");
            string Str = Console.ReadLine();

            int i = 0;
            int aa= 0;
            int e = 0;
            int o = 0;

            foreach (var letter in Str)
            {
                if (letter == 'i')
                {
                    i++;
                }
                else if (letter == 'a')
                {
                    aa++;
                }
                else if (letter == 'e')
                {
                    e++;
                }
                else if (letter == 'o')
                {
                    o++;
                }
            }

            Console.WriteLine($"{i}, {aa}, {e}, {o}");

            //      #3
            Console.WriteLine("Give me 10 numbers (csv) : ");
            var userNymber = Console.ReadLine()!;
            var numberStrings = userNymber.Split(',');

            // TODO: validate at least 5 numbers
            if (numberStrings.Length < 5)
            {
                return;
            }

            var numbersList = new List<int>();
            foreach (var number in numberStrings)
            {
                int n = int.Parse(number);
                numbersList.Add(n);
            }

            // check if all positive
            bool isNegative = false;
            foreach (var item in numbersList)
            {
                if (item < 0)
                {
                    isNegative = true;
                    break;
                }
            }

            int resultInt = 0;
            if (isNegative)
            {
                resultInt = 1;

                // false? product of last 5 element
                for (int d = numbersList.Count() - 1; d >= numbersList.Count() - 5; d--)
                {
                    resultInt *= numbersList[d];

                }
            }
            else
            {
                // true? sum of first 5 elements
                for (int d = 0; d < 5; d++)
                {
                    resultInt += numbersList[d];
                }
            }
            Console.WriteLine(resultInt);
        }
    }
}


