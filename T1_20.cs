﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13042_Tiya_sangani
{
    internal class T1_20
    {
        static void Main(string[]args)
        {
            int rows = 4; 
            int number = 1;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(number + " ");
                    number++;
                }

                Console.WriteLine(); 
            }
        }
    }
}
