using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_14
    {
        static void Main(string[]args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five",
                           "Six", "Seven", "Eight", "Nine" };

            Console.Write("Output: ");
            foreach (char digit in input)
            {
                if (char.IsDigit(digit))
                {
                    int index = digit - '0'; 
                    Console.Write(words[index] + " ");
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter digits only.");
                    return;
                }
            }

            Console.WriteLine(); 
        }
    }
}
