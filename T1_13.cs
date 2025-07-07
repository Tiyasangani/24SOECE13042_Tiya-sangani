using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_13
    {
        static void Main(string[]args)
        {
            int n = 11; 
            int a = 0, b = 1;

            Console.Write(a + " " + b + " ");

            for (int i = 2; i < n; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }

            Console.WriteLine(); 
        }
    }
}
