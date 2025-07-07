using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_10
    {
        static void Main(string[]args)
        {
            Console.Write("Enter your mobile number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                // Take the first part (excluding last 5 digits)
                string visiblePart = mobile.Substring(0, mobile.Length - 5);

                // Mask the last 5 digits with X
                string maskedPart = new string('X', 5);

                string result = visiblePart + maskedPart;

                Console.WriteLine("OUTPUT: " + result);
            }
            else
            {
                Console.WriteLine("Invalid mobile number. Must be at least 5 digits.");
            }
        }
    }
}
