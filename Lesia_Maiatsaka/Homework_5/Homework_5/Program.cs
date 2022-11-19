namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var developers = new List<IDeveloper>();
            developers.Add(new Builder { Tool = "Crane" });
            developers.Add(new Builder { Tool = "Shovel" });
            developers.Add(new Builder { Tool = "Hammer" });
            developers.Add(new Programmer { Tool = "C#" });
            developers.Add(new Programmer { Tool = "C++" });
            developers.Add(new Programmer { Tool = "Html"});

            foreach (var developer in developers) 
            {
                Console.WriteLine(developer.Create());
                Console.WriteLine(developer.Destroy());
            }

            developers.Sort();
            Console.WriteLine();
            foreach (var developer in developers)
            {
                Console.WriteLine(developer.Create());
                Console.WriteLine(developer.Destroy());
            }

            // linq
            // developers = developers.OrderBy(i => i.Tool).ToList();
        }
    }
}