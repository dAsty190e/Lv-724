using System;

namespace HomeWork2
{
    internal class Program
    {
        enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted }
        static void Main(string[] args)
        {
            //Task 1
            int dayNumber = 0;
            int monthNumber = 0;
           
            do
            {
                Console.Write("Enter the day number: ");
                dayNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the month number: ");
                monthNumber = Convert.ToInt32(Console.ReadLine());

                if ((dayNumber < 1 || dayNumber > 31) || (monthNumber < 1 || monthNumber > 12))
                    Console.WriteLine("The data is invalid");
                else break;
            }
            while (true);

            Console.WriteLine($"The day is {dayNumber}, the month is {monthNumber}");


            //Task2
            Console.Write("Enter the floating point number: ");
            double sourceNum = Convert.ToDouble(Console.ReadLine());
            int temp = (int) ((sourceNum - (int)sourceNum) * 100);
            Console.WriteLine(temp);

            int firstDigit = temp / 10;
            int secondDigit = temp % 10;

            Console.WriteLine($"First digit is {firstDigit}, second digit is {secondDigit}, their sum is {firstDigit + secondDigit}");



            //Task3
            Console.Write("Enter the current hour in digital format: ");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((hour < 12) ? "Good Morning" : (hour < 18) ? "Good afternoon" : "Good Evening");


            //Task4
            TestCaseStatus obj = TestCaseStatus.Pass;
            Console.WriteLine(obj);


            //Task5
            RGB firstPixel = new RGB(255, 255, 255); 
            RGB secondPixel = new RGB(0, 0, 0);
                     
            



        }

        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;
            public RGB(byte red, byte green, byte blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
            }
        }
    }
}
