using System;
namespace Homework5
{
    public class Builder
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


