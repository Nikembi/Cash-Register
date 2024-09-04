using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Cash_Register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal startingBalance = 0.00m;
            decimal currentBalance = startingBalance;

            Console.WriteLine("Welcome to the Cash Register Application!");
            Console.Write("Enter the starting balance from bank withdrawal: ");
            startingBalance = decimal.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("\n1. Make a Sale");
                Console.WriteLine("2. Exit");
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Write("Enter the charge for the sale: ");
                    decimal charge = decimal.Parse(Console.ReadLine());

                    if (charge > 100)
                    {
                        Console.WriteLine("Bills greater than $100 cannot be accepted.");
                        continue;
                    }

                    Console.Write("Enter the amount of cash given by the customer: ");
                    decimal cashGiven = decimal.Parse(Console.ReadLine());

                    if (cashGiven < charge)
                    {
                        Console.WriteLine("Insufficient cash given by the customer.");
                        continue;
                    }

                    decimal change = cashGiven - charge;

                    if (change > currentBalance)
                    {
                        Console.WriteLine("Cannot give more change than is available in the drawer.");
                        continue;
                    }

                    currentBalance -= change;

                    Console.WriteLine($"Transaction successful! Change due: {change:C}");
                }
                else if (option == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }
            }

            Console.WriteLine($"Final balance: {currentBalance:C}");
            Console.WriteLine("Thank you for using the Cash Register Application!");
        }
    }
}

