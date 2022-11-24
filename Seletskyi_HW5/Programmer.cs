using System;
using System.Collections.Generic;
using System.Text;

namespace Seletskiy_HW5
{
    class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        private string language;

        private string profession;

        public string Tool
        {
            get
            {
                return this.language;
            }

            set
            {
                this.language = value;
            }
        }

        public string Profession
        {
            get
            {
                return this.profession;
            }

            set
            {
                this.profession = value;
            }
        }

        public Programmer(string lang, string prof)
        {
            this.language = lang;
            this.profession = prof;
        }

        public void Create()
        {
            Console.WriteLine("{0} wrote some code using {1}", this.profession, this.language);
        }

        public void Destroy()
        {
            Console.WriteLine("{0} deleted a project written in {1}", this.profession, this.language);
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
