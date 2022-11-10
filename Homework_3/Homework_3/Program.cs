using Humanizer;
using Task_3;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #1
            //Console.WriteLine("Give me some text!");
            //var userInput = Console.ReadLine()!;

            //int a = 0;
            //int i = 0;
            //int o = 0;
            //int e = 0;
            //foreach (var item in userInput)
            //{
            //    if (item == 'a')
            //    {
            //        a++;
            //    }
            //    if (item == 'i')
            //    {
            //        i++;
            //    }
            //    if (item == 'o')
            //    {
            //        o++;
            //    }
            //    if (item == 'e')
            //    {
            //        e++;
            //    }
            //}
            //Console.WriteLine($"{a}, {i}, {o}, {e}");

            // #2

            // month
            //Console.WriteLine("\nGive me the month : ");
            //var userMonth = Console.ReadLine()!;
            //var month = int.Parse(userMonth);
            //// year
            //Console.WriteLine("\nGive me a year : ");
            //var userYear = Console.ReadLine()!;
            //var year = int.Parse(userYear);

            //Console.WriteLine("Days in the month:" + DateTime.DaysInMonth(year, month));

            // #3

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
            var anyNegative = numbersList.Any(b => b < 0);

            int resultInt = 0;
            if (anyNegative)
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

            //Console.WriteLine("Give me 10 numbers (csv) : ");
            //Console.WriteLine(Task_6.Run(Console.ReadLine()!.Split(',')));
        }
    }
}

