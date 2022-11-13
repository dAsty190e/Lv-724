namespace Cat_Hunger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feed me!");

            var cat = new Cat();
            var random = new Random();
            cat.HungerLevel = random.Next(1, 100);

            do
            {
                Console.WriteLine($"Your cat hunger on {cat.HungerLevel}");
                Console.WriteLine($"Feed the cat until he is fool");
                System.Collections.IList list = Enum.GetValues(typeof(Food));
                for (int i = 1; i < list.Count+1; i++)
                {
                    object? catfood = list[i - 1];
                    Console.WriteLine(i + ". " + $"{catfood}");
                }

                var userInput = Console.ReadKey().KeyChar;
                string enamIndex = userInput.ToString();
                Array values = Enum.GetValues(typeof(Food));
                var enamNum = values.GetValue(Convert.ToInt32(enamIndex) -1);
 
                Console.WriteLine($"You give {enamNum} to cat, now {cat.EatSomething((Food)enamNum)} ");
                Console.Clear();

            } while (cat.HungerLevel < 100);

            Console.WriteLine("\nCat is fool ^.^ ");
        }
    }
}