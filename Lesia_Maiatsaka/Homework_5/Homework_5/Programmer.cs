using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    public class Programmer : IDeveloper
    {
        private string _language;
        public string Tool { get { return _language; } set { _language = value; } }

        public int CompareTo(IDeveloper? other)
        {
            if (other == null) return 1;
            return Tool.CompareTo(other.Tool);
        }

        public string Create()
        {
            return $"Create programmer {_language}";
        }

        public string Destroy()
        {
            return "Destroy programmer";
        }
    }
}
