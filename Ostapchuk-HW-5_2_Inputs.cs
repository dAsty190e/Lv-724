using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostapchuk_HW_5_2
{
    internal class Inputs
    {
        private string val;
        private uint key;



        public string Val
        {
            get { return val; }
            set { val = value; }
        }


        public uint Key
        {
            get { return key; }
            set { key = value; }
        }



        static void FillDic()
        {
            Console.WriteLine($"Enter the Key ID: ");
            uint key = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Enter the Value: ");
            string val = Console.ReadLine();
            Dictionary<uint, string> personInfo = new Dictionary<uint, string>();
            personInfo.Add(key, val);

        }
    }
}
