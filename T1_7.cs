using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_7
    {
        static void Main(string[]args)
        {
            int num1, res, i;

            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            i = 1; // Initialization

            // Loop to print multiplication table from 1 to 10
            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);
                i++; // Increment i by one
            }

            Console.ReadLine(); // To keep the console window open
        }
    }
}
