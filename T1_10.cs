using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your mobile number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string firstPart = mobile.Substring(0, mobile.Length - 5);

                string hiddenPart = "XXXXX";

                string result = firstPart + hiddenPart;

                Console.WriteLine("OUTPUT: " + result);
            }
            else
            {
                Console.WriteLine("Mobile number must be at least 5 digits.");
            }
        }
    }
}
