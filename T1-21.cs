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
            Console.Write("Input the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            int term = 0;
            int sum = 0;

            Console.Write("Series: ");

            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + digit;
                sum += term;

                Console.Write(term);
                if (i < n)
                    Console.Write(" + ");
            }

            Console.WriteLine("\nThe Sum is : " + sum);
        }
    }
}
