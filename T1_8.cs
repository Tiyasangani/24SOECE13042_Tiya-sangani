using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_8
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            string upperName = name.ToUpper();

            Console.WriteLine("OUTPUT: " + upperName);
        }
    }
}
