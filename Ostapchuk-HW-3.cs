using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HW 1//////////////////////////////
            string inputString = "aa  oo ii ee";
            int charCounter = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'a' ||
                    inputString[i] == 'o' ||
                    inputString[i] == 'i' ||
                    inputString[i] == 'e')
                {
                    charCounter++;

                }
            }
            Console.WriteLine(charCounter);
            Console.ReadKey();

            

            //HW-2.1 ///////////////////////////////////////////////////
            
            int month = Convert.ToInt32(Console.ReadLine());
            //string year = String.Format("{0:yyyy}",DateTime.Now); //string year = DateTime.Today.ToString("yyyyy");
            string year = Console.ReadLine();
            double currentYear = Convert.ToDouble(year);
            int dayInMonth = 0;
            bool flag = false;

            if (month == 1 || month == 3 || month == 5 || month == 7 ||
                month == 8 || month == 10 || month == 11)
            {
                dayInMonth = 31;
            }
            else if (month == 2)
            {

                if (currentYear % 4 == 0)
                {
                    flag = true;
                    if ((currentYear % 100 == 0) && (currentYear % 400 != 0))
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("year is a leap");
                    dayInMonth = 29;
                }
                else
                {
                    Console.WriteLine("year is not a leap");
                    dayInMonth = 28;
                };
            }


            //HW-2.2///////////////////////////////////////////////////
            Console.WriteLine("Day in month: " + dayInMonth);
            Console.WriteLine(year);
            Console.ReadKey();

            int year2 = 2022;
            int month2 = 1;
            Console.WriteLine(getNumberOfDates(year2, month2));

            Console.ReadKey();



            //HW-3////////////////////////////////////////////////////
            int[] data = new int[] { 1, -1, 1, 1, 1, 10, 1, 1, 2, 1 };
            int sum = 0;
            int counter = 0;
            int product = 1;
            foreach (int item in data)
            {
                if (counter < 5)
                {
                    if (item >= 0)
                    {
                        sum = sum + item;
                    }
                    else
                    {
                        Console.WriteLine("negative item is present");
                    }
                }

                if (counter >= 6)
                {
                    product *= item;
                }

                counter++;

            }
            Console.WriteLine("sum 5" + "  is " + sum);
            Console.WriteLine("prod" + "  is " + product);
            Console.ReadKey();
        }
        static int getNumberOfDates(int year2, int month2)
        {
            int days = DateTime.DaysInMonth(year2, month2);

            return days;
        }
    }
}
