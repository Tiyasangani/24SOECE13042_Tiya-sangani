using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_4
    {
        static void Main(string[]args)
        {
            Console.Write("Enter Number: ");
            string str = Console.ReadLine();
            int x = Convert.ToInt32(str);

            if (x % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }

            Console.Read();  
        }
    }
}
