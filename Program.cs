using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Cash_Register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double registerBalance = 50.00;

            //Start of application
            Console.WriteLine("Welcome to the Cash Register Application!");

            //Handles the Deposit from bank to userBalance
            Console.WriteLine($"How much would you like to deposit? : ");
            var userInput = Convert.ToDouble(Console.ReadLine());
            Balhandler(userInput);

            Console.WriteLine("Enter Item price: ");
            var pricingInput = Convert.ToDouble(Console.ReadLine());
            var charge = userInput - pricingInput;
            
            if (pricingInput > userInput)
            {
                Console.WriteLine("Insufficient Funds, Add more from bank");
            }
            else
            {
                Console.WriteLine($"Success!, You're balance is now {charge}");
            }
            List<Transactions> transactionList = new List<Transactions>
            {
                new Transactions
                {
                    TransactionId = 1,
                    ProductName = "Lotion",
                    Charge = 8.00,
                    CashGiven = userInput,

                }
            };
        }

        static void Balhandler(double userBalance)
        {
            if (userBalance == 0 || userBalance > 100)
            {
                Console.WriteLine("You cant do that dumb sht");
            }
            else
            {
                Console.WriteLine($"Success, You're current balance is now: {userBalance}");

            }
        }
        static void cRegister()
        {
         
        }
        static void ProductCharge(double prodPrice)
        {
            if (prodPrice == 0)
            {
                Console.WriteLine("Invalid product pricing, Please try again.");
            }
                throw new NotImplementedException();
        }
      
    }
}

