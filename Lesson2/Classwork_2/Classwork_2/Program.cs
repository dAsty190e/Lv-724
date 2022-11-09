using System;

namespace Classwork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  CLASSWORK     TASK_1

            int dayNum, monthNum;

            Console.WriteLine("Give me the day");
            dayNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me the month");
            monthNum = int.Parse(Console.ReadLine());


            string day = (dayNum <= 12) ?
                         "dayNum can represent day: " + dayNum :
                         "dayNum cant represent day: " + dayNum;
            string month = (monthNum <= 31) ?
                           "monthNum can represent month: " + monthNum :
                           "monthNum cant represent month" + monthNum;

            Console.WriteLine(month + "\n" + day);



            //  CLASSWORK     TASK_2

            Console.WriteLine("\nGive me a double. Example: 23.3456");
            double number = Convert.ToDouble(Console.ReadLine());
            var numberAsString = number.ToString();

            var indexOfDot = numberAsString.IndexOf('.');
            var firstIndex = int.Parse(numberAsString[indexOfDot + 1].ToString());
            var secondIndex = int.Parse(numberAsString[indexOfDot + 2].ToString());
            Console.WriteLine(firstIndex + secondIndex);


            //  CLASSWORK  TASK_3

            int h = int.Parse(Console.ReadLine());

            Console.WriteLine
            (
                (h >= 0) && (h < 6) ? "Good morning" :
                (h >= 6) && (h < 12) ? "Good afternoon" :
                (h >= 12) && (h < 16) ? "Good evening" :
                (h >= 16) && (h < 23) ? "Good night" :
                                        "Type another number");


            //  CLASSWORK TASK_4

            var test1Status = (TestCaseStatus.Pass);
            Console.WriteLine("test1Status: " + test1Status);


            //  CLASSWORK     TASK_5

            var color = new colorRGB();
            Console.WriteLine("\nWhite " + color.SetColor(255, 255, 255) + "\n Black " + color.SetColor(0, 0, 0));
            Console.WriteLine();
        }


        //  CLASSWORK   TASK_4

        enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted
        };

        //  CLASSWORK   TASK_5

        struct colorRGB
        {
            public byte r, g, b;

            public string SetColor(byte r, byte g, byte b)
            {
                return string.Format("({0},{1},{2})", r, g, b);
            }
        }
    }
}
