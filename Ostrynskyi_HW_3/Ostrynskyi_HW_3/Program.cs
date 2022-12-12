using System.Diagnostics.Metrics;
using System.Xml;
public class HW_3
{
    public static void Main()
    {
        //Task 1
        Console.WriteLine("Please enter random text");
        string source = Convert.ToString(Console.ReadLine());

        int a = source.Length - source.Replace("a", "").Length;
        int b = source.Length - source.Replace("o", "").Length;
        int c = source.Length - source.Replace("i", "").Length;
        int d = source.Length - source.Replace("e", "").Length;

        Console.WriteLine($"The character 'a' occures {a} times," +
        $"\nThe character 'o' occures {b} times," +
        $"\nThe character 'i' is {c} times," +
        $"\nThe character 'e' is {d} times");
        Console.ReadKey();

        //Task 2
        Console.WriteLine("Please, enter the number of the month");

        string mounth = Convert.ToString(Console.ReadLine());

        switch (mounth)
        {
            case "1":
                Console.WriteLine("January has 31 days");
                break;

            case "2":
                Console.WriteLine("Please, enter the year");

                int year = Convert.ToInt32(Console.ReadLine());
                if (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0))
                {
                    Console.WriteLine("February has 28 days");
                }
                else
                {
                    Console.WriteLine("February has 29 days");
                }
                break;

            case "3":
                Console.WriteLine("March has 31 days");
                break;
            case "4":
                Console.WriteLine("April has 30 days");
                break;

            case "5":
                Console.WriteLine("May has 31 days");
                break;
            case "6":
                Console.WriteLine("June has 30 days");
                break;

            case "7":
                Console.WriteLine("July has 31 days");
                break;
            case "8":
                Console.WriteLine("August has 31 days");
                break;

            case "9":
                Console.WriteLine("September has 30 days");
                break;
            case "10":
                Console.WriteLine("October has 31 days");
                break;

            case "11":
                Console.WriteLine("November has 30 days");
                break;
            case "12":
                Console.WriteLine("December has 31 days");
                break;
        }

        //Task 3
        int i = 0;
        int sum = 0;
        int prod = 1;
        bool positive = true;
        int[] array = new int[10];
        Console.WriteLine("Please, Enter 10 integer numbers");

        while (i < 10)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }
        for (i = 0; i < 5; i++)
        {

            if (array[i] < 0)
            {
                positive = false;
                break;
            }

            if (array[i] > 0)
            {
                positive = true;
            }
        }
        if (positive)
        {
            for (i = 0; i < 5; i++)
            { sum += array[i]; }
            Console.WriteLine($"The sum the first five integers is {sum}");
        }
        if (positive == false)
        {
            for (i = 5; i < 10; i++)
            { prod *= array[i]; }
            Console.WriteLine($"The product of the last five integers is {prod}");
        }
    }
}