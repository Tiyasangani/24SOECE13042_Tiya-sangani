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
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            string result = "";

            foreach (char c in name)
            {
                if (char.IsUpper(c))
                {
                    result += char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    result += char.ToUpper(c);
                }
                else
                {
                    result += c;
                }
            }

            Console.WriteLine("OUTPUT: " + result);
        }
    }
}
