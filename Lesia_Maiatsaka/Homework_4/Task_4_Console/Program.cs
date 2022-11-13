using Task_4;

namespace Task_4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Forester", "Blue", 120_000);
            var car2 = new Car("Impreza", "White", 90_000);
            var car3 = new Car("Legacy", "Red", 110_000);
            var car4 = new Car("Legacy", "Red", 110_000);
            Console.WriteLine(car3 == car4);

            car1.ChangePrice(1.1);
            car2.ChangePrice(1.25);
            car3.ChangePrice(0.9);

            car2.Color = "Black";

            Console.WriteLine(car1.Print());    
            Console.WriteLine(car2.Print());    
            Console.WriteLine(car3.Print());

        }
    }
}