using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_HW_5
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {
        private string name;
        private string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        public Builder(string name, string tool)
        {
            this.name = name;
            this.tool = tool;
        }
        public void Create()
        {
            Console.WriteLine($"Builder {name} creates something with help of {tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder {name} destroy something with help of {tool}");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

    }
}
