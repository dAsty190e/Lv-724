namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define integer variable a (side of the square)

            Console.WriteLine("Lets find out what is the sides of the square");
            Console.WriteLine("\nHow long is one side of the square?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nThe perimeter is {a * 4}");
            Console.WriteLine($"\nThe area is {a * a}");

            // Define string name and integer age

            string userInput;
            string name;
            int age;

            Console.WriteLine("\nWhat is your name?");
            userInput = Console.ReadLine();
            name = userInput;

            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"It is wonderful {name}?");
            }

            var isParsing = false;
            do
            {
            Console.WriteLine($"\nHow old are you {name}?");
            userInput = Console.ReadLine();
            isParsing = int.TryParse(userInput, out age);

            } while (isParsing == false);

            Console.WriteLine($"{name} your age is {age}");


            // Read double number r (radius of a circle).
            // Calculate the length(l = 2 * pi * r), area(S = pi * r * r), and volume(4 / 3 * pi * r * r * r) of a circle

            Console.WriteLine("\nGive me the radius of a circle");
            string userRadius = Console.ReadLine();

            double r = double.Parse(userRadius);
            var length = 2 * Math.PI * r;
            var area = Math.PI * r * r;
            var volume = 4 / 3 * Math.PI * r * r * r;

            Console.WriteLine($"Length : {length}");
            Console.WriteLine($"Area : {area}");
            Console.WriteLine($"Volume : {volume}");
        }
    }
}