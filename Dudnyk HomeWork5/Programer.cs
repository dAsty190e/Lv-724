using System;
namespace HomeWork5
{
    public class Programer : IDeveloper, IComparable
    {
        private string lang;
        public string Tool
        {
            get
            {
                return lang;
            }
            set
            {
                lang = value;
            }
        }

        public void Create()
        {
            Console.WriteLine("Hello developer, create a programe using " + lang);
        }

        public void Destroy()
        {
            Console.WriteLine("Destroy the world");
        }

        public int CompareTo(object o)
        {
            Programer p = o as Programer;
            Builder b = o as Builder;
            if (p != null)
                return this.Tool.CompareTo(p.Tool);
            else if (b != null)
                return this.Tool.CompareTo(b.Tool);
            else
                throw new ArgumentException("Object is not a developer");

        }

        public Programer()
        {
            lang = "C#";
        }

        public Programer(string s)
        {
            lang = s;
        }

        public override string ToString()
        {
            return this.Tool;
        }
    }
}

