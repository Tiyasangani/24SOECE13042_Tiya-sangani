using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_14
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();

            string[] words = { "Zero", "One", "Two", "Three", "Four",
                           "Five", "Six", "Seven", "Eight", "Nine" };

            Console.Write("Output: ");

            foreach (char c in number)
            {
                if (c >= '0' && c <= '9')
                {
                    int digit = c - '0';
                    Console.Write(words[digit] + " ");
                }
                else
                {
                    Console.WriteLine("\nPlease enter digits only.");
                    return;
                }
            }
        }

    }
}
