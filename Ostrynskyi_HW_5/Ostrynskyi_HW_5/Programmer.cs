using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostrynskyi_HW_5
{
    internal class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        private string name;
        private string language;
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }
        public Programmer(string name, string language)
        {
            this.name = name;
            this.language = language;
        }
        public void Create()
        {
            Console.WriteLine($"Programmer {name} creates something with help of {language}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer {name} destroy something with help of {language}");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

    }
}
