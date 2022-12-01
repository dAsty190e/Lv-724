using System;
using System.Collections.Generic;
using System.Text;

namespace HM5
{
    class Builder : IDeveloper, IComparable
    {
        string tool;
        public string Tool
        {
            set { tool = value; }
            get { return tool; }
        }

        public Builder(string tool)
        {
            this.tool = tool;
        }
        public static Builder Input(int i)
        {
            Console.WriteLine($"{i + 1} enter your tool");
            string tool = Console.ReadLine();
            Builder builder = new Builder(tool);
            return builder;
        }
        public void Create()
        {
            Console.WriteLine($"The tool is {this.tool}");
        }
        public void Destroy()
        {
            if (tool != "hammer")
            {
                Console.WriteLine("your language isn't c# ");
            }
            else
            {
                Console.WriteLine("youк tool isn't hammer");
            }
        }
        public Builder() { }
        public int CompareTo(object o)
        {
            Builder b = o as Builder;
            if (b != null)
                return this.Tool.CompareTo(b.Tool);
            else
                throw new ArgumentException("Object is not a developer");
        }
    }
}
