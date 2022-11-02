namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, indicate the length of the square side");
            int a = Convert.ToInt32(Console.ReadLine());

            int area = a * a;
            int perimeter = a * 4;

            Console.WriteLine($"Therefore, the area of the square is {area} and the perimeter is {perimeter}");
            Console.WriteLine();

            Console.WriteLine("What is your name?");
            string name = (Console.ReadLine());

            Console.WriteLine("What is your age?");
            string age = (Console.ReadLine());

            Console.WriteLine($"So, you are {name} and your age is {age}");
            Console.WriteLine();

            Console.WriteLine("Please, indicate the radius of the circle");
            double r = Convert.ToDouble(Console.ReadLine());

            double circle_area = Math.PI * r * r;
            double length = 2 * Math.PI * r;
            double volume = 4 / 3 * Math.PI * r * r * r;

            Console.WriteLine($"So, the area of the circle is {Math.Round(circle_area,2)}, " +
                $"the length is {Math.Round(length,2)} and the volume is {Math.Round(volume,2)}");
            Console.ReadKey();
        }
    }
}