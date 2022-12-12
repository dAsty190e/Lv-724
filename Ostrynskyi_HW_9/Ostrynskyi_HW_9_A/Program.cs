using Ostrynskyi_HW_8;
using Ostrynskyi_HW_9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_HW_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();
            shapeList.Add(new Circle("Сircle 1", 1));
            shapeList.Add(new Square("Сircle 2", 2));
            shapeList.Add(new Circle("Сircle 3", 3));
            shapeList.Add(new Square("Square 1", 2));
            shapeList.Add(new Circle("Square 2", 85));
            shapeList.Add(new Square("Square 3", 99));

            string path = @"C:\Users\Dell\Desktop\file.txt";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < shapeList.Count; i++)
                {
                    if (shapeList[i].Area() >= 10 && shapeList[i].Area() <= 100)
                    {
                        sw.WriteLine($"Name: {shapeList[i].Name}, value of area: {shapeList[i].Area()}");
                    }
                }
                for (int i = 0; i < shapeList.Count; i++)
                {
                    if (shapeList[i].Name.Contains("a"))
                    {
                        sw.WriteLine($"Name: {shapeList[i].Name}");
                    }
                }
                for (int i = 0; i < shapeList.Count; i++)
                {
                    if (shapeList[i].Perimeter() < 50)
                    {
                        shapeList.Remove(shapeList[i]);
                    }
                    Console.WriteLine($"{shapeList[i].Name} with perimeter: {shapeList[i].Perimeter()}");
                }
                
                //Console.WriteLine(shapeList.RemoveAll(x => x.Perimeter() < 5)); 
                //але таких фігур в списку немає, бо у всіх перимерт більше 5
                
            }
                        
        }
    }
}