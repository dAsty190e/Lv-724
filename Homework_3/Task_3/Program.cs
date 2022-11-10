using Humanizer;
using System.Linq;
using System.Collections.Generic;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1
            var range = Enumerable.Range(1, 100);

            int count = 0;
            foreach (var item in range)
            {
                if (item % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"{count} number % 3");

            // method linq
            Console.WriteLine($"Linq {range.Where(x => x % 3 == 0).Count()} number % 3");

            // #2

            Console.WriteLine("\nGive me some text:");
            var userInput = Console.ReadLine()!;
            var userInputAfterFirstChar = userInput.Replace(" ", "")
                .Substring(1); // skip the first letter (just first step)

            for (int i = 0; i < userInputAfterFirstChar.Length; i++)
            {
                char item = userInputAfterFirstChar[i];
                if (i % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
            // method linq 
            var even = userInput.Replace(" ", "").Skip(1).Select((letter, index) => new { letter, index }).Where((x) => x.index % 2 == 0);
            foreach (var item in even)
            {
                Console.WriteLine(item.letter);
            }

            // #3
            var drink = new Drinks[]
            {
                new Drinks
                {
                    DrinkName = "Pepsi",
                    DrinkPrice = 15,
                    Id = 1
                },
                new Drinks
                {
                    DrinkName = "Coca-Cola",
                    DrinkPrice = 21,
                    Id = 2
                },
                new Drinks
                {
                    DrinkName = "Root-Beer",
                    DrinkPrice = 22,
                    Id = 3
                },
                new Drinks
                {
                    DrinkName = "Water",
                    DrinkPrice = 25,
                    Id = 4
                }
            };

            Console.WriteLine("What drink do you want? 1/2/3/4");
            Console.WriteLine("1. Pepsi \n2. Coca-Cola \n3. Root-Beer \n4. Water");
            var userDrink = Console.ReadLine()!;
            var number = int.Parse(userDrink);
            var result = drink.FirstOrDefault(e => e.Id == number)!;

            //Console.WriteLine($"{result.DrinkName} {result.DrinkPrice}");

            Console.WriteLine(result.Print());

            // #4 

            int sumB = 0;
            int something = -1;
            int x = 0;

            while (something != 0)
            {
                Console.Write("Enter a number: ");
                something = int.Parse(Console.ReadLine()!);

                if (something <= 0)
                {

                    Console.WriteLine($"The average of these numbers is: {sumB / x}");
                }
                else
                {
                    x++;
                    sumB += something;
                }
                break;
            }

            // post1 #4
            int[] sum = new int[4];
            Console.WriteLine("\nLets find average of the entered numbers.");

            for (int i = 1; i < sum.Length + 1; i++)
            {
                Console.WriteLine($"Give me your {i.ToOrdinalWords()} number:");
                sum[i - 1] = Convert.ToInt32(Console.ReadLine());
            }

            int resultSum = sum[0] + sum[1] + sum[2] + sum[3];
            var resultInt = resultSum / 4;

            Console.WriteLine("Your average is = " + resultInt);

            // post2 #4
            Console.WriteLine("\nLets find average of the entered numbers.");

            int num1, num2, num3, num4;

            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            int aveNum = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"The average of these numbers is: {aveNum}");

            // #5

            do
            {
                Console.WriteLine("Give me a year: ");
                var userYear = Console.ReadLine()!;
                var year = int.Parse(userYear);

                var yearCheck = new DateTime(year, 1, 1).Year;

                if (DateTime.IsLeapYear(yearCheck))
                {
                    Console.WriteLine("This is a leap year");
                }
                else
                {
                    Console.WriteLine("This is not a leap year");
                }
                Console.WriteLine("Try again? Press Y to try proceed");

            } while (Console.ReadKey(true).Key == ConsoleKey.Y);

            // #6

            Console.Write("Enter the number : ");
            var numberOf = Console.ReadLine()!;

            int n = 0;
            foreach (var numberN in numberOf)
            {
                n += int.Parse(numberN.ToString());
            }
            Console.WriteLine(n);

            // #7
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


            // post 6 LinQ
            //Console.Write("Enter the number : ");
            //Console.WriteLine(Console.ReadLine()!.Sum(e => int.Parse(e.ToString())));

        }

        public class Drinks
        {
            public string? DrinkName { get; set; }
            public int DrinkPrice { get; set; }
            public int Id { get; set; }
            public string Print()
            {
                return $"Buy {DrinkName} for {DrinkPrice}";
            }
        }
    }
}