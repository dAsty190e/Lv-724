using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework5
{
    public class Programmer : IDeveloper
    {
        public string _language;
        public string Tool { get { return _language; } set { _language = value; } }
        public int CompareTo(IDeveloper? other)
        {
            if (other == null) return 1;
            {
                return Tool.CompareTo(other.Tool);
            }
        }

        public string Create()
        {
            return $"Create programer {_language}";
        }

        public string Destroy()
        {
            return $"Destroy programer";
        }
    }
}
