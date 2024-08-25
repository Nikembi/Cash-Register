using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double startingBalance = 0.00;
            //return startingBalance; eventually to go back to 0 at end of day
            //Cannot return the startingBalance within the main method, may need to move the variable too
            //If Last transaction completes then revert currentBalance to $0.00.
            List<Transactions> transactions = new List<Transactions>();
            int transactionCount = 1;

            Console.WriteLine("Welcome to the Cash Register Application!");
            
            balance = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter cost of items");
            //reads input for what the cost of the item is
            double itemCharge = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"Your balance is: {startingBalance}");


        }
        static void cRegister(double currentBalance)
        {

            if (currentBalance > 100)
            {
                Console.WriteLine("We do not accept bills over $100 at the time.");
            }
    
        }
        static void BankWithdrawl()
        {
            double bankWithdraw = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Enter the starting balance from bank withdrawal: {bankWithdraw}");
        }
      
    }
}

