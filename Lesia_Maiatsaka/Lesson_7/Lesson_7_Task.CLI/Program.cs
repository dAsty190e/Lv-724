using Lesson_7.BLL;

namespace Lesson_7_Task.CLI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var t = new TaskClass();
            var files = await t.ReadFileAsync(@"D:\Lessons\DirectoryD.txt");
            Console.WriteLine(files);
        }
    }
}