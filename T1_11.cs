using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_11
    {
        static void Main(string[]args)
        {
            // Accept name
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            char gender = char.ToUpper(Convert.ToChar(Console.ReadLine()));

            if (gender == 'M')
            {
                Console.WriteLine("Hello, Mr. " + name);
            }
            else if (gender == 'F')
            {
                Console.WriteLine("Hello, Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid gender entered. Please enter M or F.");
            }
        }
    }
}
