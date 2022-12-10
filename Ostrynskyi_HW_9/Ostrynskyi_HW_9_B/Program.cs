using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Home_Work_9._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
                       
            string path = @"C:\Users\Dell\Desktop\text.txt";
            string[] text = File.ReadAllLines(@"C:\Users\Dell\Desktop\text.txt");
            using (StreamReader sw = new StreamReader(path, false))
            {
                int result = 0;
                foreach (string i in text)
                {
                    result += i.Length;
                }
                Console.WriteLine($"The number of symbols in every line: {result} ");
                Console.WriteLine();

                var Long = text.OrderByDescending(a => a.Length).First().ToString();
                var Short = text.OrderBy(a => a.Length).First().ToString();

                Console.WriteLine($"The longest line:'{Long}', " +
                             $"\nthe shortest line:'{Short}'");
                Console.WriteLine();

                Console.WriteLine("The line which consist of word \"var\":");
                var line = from x in text
                            where x.Contains("var")
                            select x;
                foreach (var item in line)
                {
                    Console.WriteLine(item);
                }
                                
            }
            
        }
    }
}
