using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_21
    {
        static void Main(string[]args)
        {
            Console.Write("How many terms? ");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a digit: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            int term = 0;
            int total = 0;

            Console.Write("Series: ");

            for (int i = 1; i <= count; i++)
            {
                term = term * 10 + digit;

                total = total + term;

                Console.Write(term);

                if (i < count)
                    Console.Write(" + ");
            }

            Console.WriteLine("\nSum = " + total);
        }
    }
}
