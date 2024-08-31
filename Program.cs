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
            Console.WriteLine("Welcome to the Cash Register Application!");

        }

        static void Balhandler(double userBalance, double result)
        {
            Console.WriteLine($"Amount to deposit from bank: {userBalance}");
            userBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Current balance is now: {result}");
            result = userBalance;
        }
        static void cRegister(double registerBalance, double userBalance)
        {
            registerBalance = 50.00;
        }
        static void BankWithdrawl()
        {
            

            //Console.Write($"Enter the starting balance from bank withdrawal: {bankWithdraw}");
        }
      
    }
}

