using System;

namespace Dudnyk_HW3
{
    class Letters
    {
        public int o;
        public int a;
        public int i;
        public int e;

        public Letters()
        {
            o = 0;
            a = 0;
            i = 0;
            e = 0;
        }
        public override string ToString()
        {
            return string.Format($"The count for letters is: \n\ta: {a} \n\ti: {i} \n\te: {e} \n\to: {o}");
        }
    }

    enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.Write("Enter a string: ");
            var str = Console.ReadLine();
            str = str.ToLower();

            Letters letter = new Letters();

            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == 'o')
                    letter.o++;
                else if
                    (str[i] == 'a')
                    letter.a++;
                else if
                    (str[i] == 'i')
                    letter.i++;
                else if
                    (str[i] == 'e')
                    letter.e++;
            }

            Console.WriteLine(letter);

            Console.WriteLine("\n\n");


            //Task2
            Console.Write("Enter a number of a month: ");
            Month month = (Month)Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case Month.January:
                case Month.March:
                case Month.May:
                case Month.July:
                case Month.August:
                case Month.October:
                case Month.December:
                    Console.WriteLine($"{month} has 31 days");
                    break;

                case Month.April:
                case Month.June:
                case Month.September:
                case Month.November:
                    Console.WriteLine($"{month} has 30 days");
                    break;

                case Month.February:
                    Console.Write("What year are you interested in? ");
                    int year = Convert.ToInt32(Console.ReadLine());

                    if ((year % 100 == 0 && year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                        Console.WriteLine($"The {year} year is a leap year, there are 29 days in {month}");

                    else
                        Console.WriteLine($"The {year} year is not leap year, there are 28 days in {month}");

                    break;

                default:
                    Console.WriteLine("Sorry, no such month");
                    break;
            }

            Console.WriteLine("\n\n");


            //Task3
            int n = 10;
            int[] arr = new int[n];

            for (int i = 0; i < n; ++i)
            {
                Console.Write($"Enter {i + 1} integer from {n}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool isPositive = true;
            int sum = 0;
            int product = 1;

            for (int i = 0; i < 5; ++i)
            {
                if (arr[i] > 0)
                    sum += arr[i];
                else
                {
                    isPositive = false;
                    break;
                }
            }

            if (!isPositive)
            {
                for (int i = 5; i < n; ++i)
                {
                    product *= arr[i];
                }
                Console.WriteLine("The product of last 5 elements is {0}", product);
            }
            else
                Console.WriteLine($"The sum of first 5 elements is {sum}");

            Console.ReadKey();
        }   
    }
}

