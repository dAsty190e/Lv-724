using System;
using System.Collections.Generic;
using System.Text;

namespace Seletskiy_HW5
{
    class Builder : IDeveloper, IComparable<IDeveloper>
    {
        private string tool;
        private string profession;

        public string Tool
        {
            get
            {
                return this.tool;
            }

            set
            {
                this.tool = value;
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

        public Builder(string tool, string profession)
        {
            this.tool = tool;
            this.profession = profession;
        }

        public void Create()
        {
            Console.WriteLine("{0} built something using a {1}", this.profession, this.tool);
        }

        public void Destroy()
        {
            Console.WriteLine("{0} destroyed something using a {1}", this.profession, this.tool);
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
