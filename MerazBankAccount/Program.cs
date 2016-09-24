using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MerazBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Move to account class
            string clientName = "Shilling Rich";

            //Move to account class
            int checkingAccNum = 123456789;
            int reserveAccNum = 123456;
            int savingsAccNum = 0123456789;

            Console.WriteLine("Welcome to Future Investments Bank.");

            //Objects

            // Minimum 1 object instantiated from the Checking Account Class
            // Insert Checking constructor with parameters for minimum balance, interest, 
            // Minimum 1 object instantiated from the Reserve Account Class
            // Minimum 1 object instantiated from the Savings Account Class


            //Other Required Tasks

            // Use StreamWriter to create account summary files that track transactions for each account type
            //(each type has its own text file)
            //Files should be located in the Debug Folder and should include:
            StreamWriter checkHistory = new StreamWriter("..\\..\\checkHistory.txt");

            using (checkHistory)
            {
                // Name of Client
                checkHistory.WriteLine("Transaction History for " + clientName + "\n");
                // Client Account Number
                checkHistory.WriteLine("Account number: " + checkingAccNum);
                // Account Type(Checking, Reserve, or Savings)
                checkHistory.WriteLine("Account type: Checking\n\n");
                // Each transaction should be on its own line
                //foreach (/*transaction in Checking*/)
                //{
                //    checkHistory.WriteLine("DateTime +//- $amount NewBalance\n");
                //    // Each transaction should show date and time of transaction(must use DateTime Class)
                //    // Each transaction should show a “+” for deposit and a “-” for withdrawal
                //    // Each transaction should show the transaction amount
                //    // Each transaction should show the new current balance after the transaction
                //}
            }
        }
    }
}
