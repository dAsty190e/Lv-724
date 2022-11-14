using System;
using System.Threading.Tasks;

namespace Sytnyk_Illia_s_Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Enter some text: ");
            string text = Convert.ToString(Console.ReadLine());
            string some_text = text.ToLower();

            int count_a = 0;
            int count_o = 0;
            int count_i = 0;
            int count_e = 0;

            for (int i = 0; i < some_text.Length; i++)
            {
                if (Convert.ToChar(some_text[i]) == 'a')
                {
                    count_a += 1;
                }
            }

            for (int i = 0; i < some_text.Length; i++)
            {
                if (Convert.ToChar(some_text[i]) == 'o')
                {
                    count_o += 1;
                }
            }

            for (int i = 0; i < some_text.Length; i++)
            {
                if (Convert.ToChar(some_text[i]) == 'i')
                {
                    count_i += 1;
                }
            }

            for (int i = 0; i < some_text.Length; i++)
            {
                if (Convert.ToChar(some_text[i]) == 'e')
                {
                    count_e += 1;
                }
            }

            Console.WriteLine("How much 'a': " + count_a);
            Console.WriteLine("How much 'o': " + count_o);
            Console.WriteLine("How much 'i': " + count_i);
            Console.WriteLine("How much 'e': " + count_e);
            Console.WriteLine("How much 'a + o + i + e': " + (count_a + count_i + count_i + count_e));
            Console.ReadKey();

            //Task 2
            Console.WriteLine("Enter number of month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine("31 day in the month");
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                Console.WriteLine("30 day in the month");
            }
            else if (month == 2)
            {
                Console.WriteLine("28 day in the month");
            }
            else Console.WriteLine("It isn`t a month");

            Console.ReadKey();

            //Task 3
            const int SIZE = 10;
            int[] nums = new int[SIZE];
            int sum = 0;
            int prod = 0;
            bool show_prod = false;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number " + (i + 1) + " : ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (nums[i] > 0)
                {
                    sum += nums[i];
                }
                else
                {
                    prod = 1;
                    show_prod = true;
                    for (int j = 5; j < 10; j++)
                    {
                        prod *= nums[j];
                    }
                }
            }

            Console.WriteLine("--------------------");

            if (show_prod == true)
            {
                Console.WriteLine("Product = " + prod);
            }
            else Console.WriteLine("Sum = " + sum);
            Console.ReadKey();
        }
    }
}
