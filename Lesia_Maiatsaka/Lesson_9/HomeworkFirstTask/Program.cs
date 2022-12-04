using System.Text;
using System.Text.RegularExpressions;

namespace HomeworkFirstTask
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var outPutPath = @"C:\Users\mlesy\temp\Lv-724\Lesia_Maiatsaka\Lesson_9\HomeworkFirstTask\OutPut.txt";
            var readFile = @"C:\Users\mlesy\temp\Lv-724\Lesia_Maiatsaka\Lesson_9\HomeworkFirstTask\Program.cs";

            var listOfShapes = new List<Shape>
            {
                new Circle("Big Circle", 12),
                new Circle("Some Circle", 5),
                new Circle("Another Circle", 7),
                new Square("Big Square", 14),
                new Square("Some Square", 2),
                new Square("Another Square", 5)
            };

            FileStream stream = new FileStream(outPutPath, FileMode.OpenOrCreate);
            Console.WriteLine("Area check");
            foreach (Shape shape in listOfShapes.Where(e => e.Area1 >= 10 && e.Area1 <= 100)) 
            {
                Console.WriteLine(shape);
                await stream.WriteAsync(Encoding.ASCII.GetBytes(shape.ToString()));
            }

            Console.WriteLine("Contains : a");
            foreach (Shape shape in listOfShapes.Where(e => e.Name.Contains('a')))
            {
                Console.WriteLine(shape);
                await stream.WriteAsync(Encoding.ASCII.GetBytes(shape.ToString()));
            }
            stream.Close();

            Console.WriteLine("Perimeter check");
            foreach (var item in listOfShapes.Where(e => e.Perimeter1 > 5))
            {
                Console.WriteLine(item);
            }

            var file = await File.ReadAllTextAsync(readFile);
            var lines = file.Split("\n");
            Regex pattern = new Regex(@"\W|_");
            var symbolsOnly = lines.Where(e => pattern.IsMatch(e));
            foreach (var item in symbolsOnly)
            {
                foreach (var t in item)
                {
                    if (!char.IsLetterOrDigit(t))
                    {
                        Console.Write(t);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Min");
            Console.WriteLine(lines.OrderBy(e => e.Length).FirstOrDefault());
            Console.WriteLine("Max");
            Console.WriteLine(lines.OrderByDescending(e => e.Length).FirstOrDefault());

            Console.WriteLine("VAR Check");
            var varOnly = lines.Where(e => e.Contains("var"));
            foreach (var item in varOnly)
            {
                Console.WriteLine(item);
            }
        }
    }
}