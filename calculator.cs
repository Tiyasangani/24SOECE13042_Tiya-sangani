using System;

namespace _24SOECE13042_TiyaSangani
{
    internal class calculator
    {
        public static void Main(string[] args)
        {
            double a = 0, b = 0;
            string choice;

            while (true)
            {
                Console.Write(@"
1. ADD
2. Sub
3. Mul
4. Div
Enter anything else to exit!
Choice: ");
                choice = Console.ReadLine();

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter First Number: ");
                            a = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter Second Number: ");
                            b = Convert.ToDouble(Console.ReadLine());

                            break; // exit the loop when inputs are valid
                        }
                        catch
                        {
                            Console.WriteLine("Enter valid numeric input!!");
                        }
                    }

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine($"Sum of {a} and {b} is {a + b}");
                            break;
                        case "2":
                            Console.WriteLine($"Subtraction of {a} and {b} is {a - b}");
                            break;
                        case "3":
                            Console.WriteLine($"Multiplication of {a} and {b} is {a * b}");
                            break;
                        case "4":
                            if (b == 0)
                            {
                                Console.WriteLine("Division by zero is not allowed.");
                            }
                            else
                            {
                                Console.WriteLine($"Division of {a} and {b} is {a / b}");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Thank you for using the calculator :)");
                    break; // exit the main loop
                }
            }
        }
    }
}
