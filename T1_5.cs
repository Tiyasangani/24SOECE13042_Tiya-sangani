using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_5
    {
        static void Main(string[]args)  
        {
            int n, fact = 1;              // Declare two integers, n (input number) and fact (factorial result), initialize fact as 1

            Console.WriteLine("Enter Number : ");   // Ask the user to enter a number

            string str = Console.ReadLine();        // Read user input as a string

            n = Convert.ToInt32(str);                // Convert the string input to an integer and store in n

            for (int i = 1; i <= n; i++)             // Loop from 1 to n
            {
                fact = fact * i;                     // Multiply fact by i and update fact
            }

            Console.WriteLine("Factorial : {0}", fact);  // Print the factorial result

            Console.Read();                      // Wait for user to press a key before closing
        }
    }
    
}
