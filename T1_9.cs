using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_9
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter your name:");
            string input = Console.ReadLine();
            string toggleCase = "";

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    toggleCase += char.ToLower(c); 
                }
                else if (char.IsLower(c))
                {
                    toggleCase += char.ToUpper(c); 
                }
                else
                {
                    toggleCase += c; 
                }
            }

            Console.WriteLine("OUTPUT: " + toggleCase);
        }
    }
}
