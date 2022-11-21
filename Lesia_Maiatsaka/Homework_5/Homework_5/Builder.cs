using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    public class Builder : IDeveloper
    {
        private string _tool;

        public string Tool { get { return _tool; } set { _tool = value; } }

        public int CompareTo(IDeveloper? other)
        {
            if (other == null) return 1;
            return Tool.CompareTo(other.Tool);
        }

        public string Create()
        {
            return $"Builder create {_tool}";
        }

        public string Destroy()
        {
            return "Builder destroy";
        }
    }
}
