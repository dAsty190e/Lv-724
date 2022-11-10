using System;
namespace Homework3.Dima
{
    class Program
    {
        static void Main(string[] args)
        {

            //task 1
            Console.WriteLine("task 1");
            Console.WriteLine("Enter the text");
            string str = Console.ReadLine();
            int sum = 0;
            foreach (char p in str)
                if (p == 'a' || p == 'o')
                {
                    sum++;
                }
            foreach (char p in str)
                if (p == 'i' || p == 'e')
                {
                    sum++;
                }
            Console.WriteLine($"sum is {sum}");

            //task2
            Console.WriteLine("task 2");
            Console.WriteLine("Enter the number of month");
            int month = Convert.ToInt32(Console.ReadLine());
            int[] months = new int[7] { 1, 3, 5, 7, 8, 10, 12 };
            int[] months2 = new int[4] { 4, 6, 9, 11 };
            foreach (int p in months)
                if (month == p)
                {
                    Console.WriteLine("This month has 31 days");
                }
            foreach (int p in months2)
                if (month == p)
                {
                    Console.WriteLine("This month has 30 days");
                }
            if (month == 2)
            {
                Console.WriteLine("This month has 28 or 29 days");
            }

            //task 3
            Console.WriteLine("Task 3");
            int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 0;
            int summ = 0;
            int multiplication = 0;
            foreach (int p in nums)
                if (p >= 0 && k < 5)
                {
                    summ += p; k++;
                }
            Console.WriteLine($"sum is {summ}");
            // 3 завдання шось не виходить в мене зробити оту другу частину, де множення останніх п'яти(

        }
    }

}