using Task_4;

namespace Task_4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Forester", CarColors.Blue, 120_000);
            var car2 = new Car("Impreza", CarColors.White, 90_000);
            var car3 = new Car("Legacy", CarColors.Red, 110_000);
            var car4 = new Car("Legacy", CarColors.Red, 110_000);
            Console.WriteLine(car3 == car4);
           
            Console.WriteLine(car1.Print());
            Console.WriteLine(car2.Print());
            Console.WriteLine(car3);
            Console.WriteLine("Which car would you like? 1, 2, 3");
            var userCar = Console.ReadKey().Key;
            Console.WriteLine("What color would you like?");
            Console.WriteLine(string.Join(", ", Enum.GetNames(typeof(CarColors))));
            if (userCar == ConsoleKey.D1)
            {
                car1.CarColorChange(Console.ReadLine());
                Console.WriteLine(car1);
            }
            else if (userCar == ConsoleKey.D2)
            {
                car2.CarColorChange(Console.ReadLine());
                Console.WriteLine(car2);
            }
            else if (userCar == ConsoleKey.D3)
            {
                car3.CarColorChange(Console.ReadLine());
                Console.WriteLine(car3);
            }
            else 
            {
                car4.CarColorChange(Console.ReadLine());
                Console.WriteLine(car4);
            }
            

        }
    }
}