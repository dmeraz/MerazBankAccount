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
            string clientName = "Shilling Rich";
            int checkingAccNum = 123456789;
            int reserveAccNum = 12345678;
            int savingsAccNum = 0123456789;

            //Objects

            // Minimum 1 object instantiated from the Checking Account Class
            // Minimum 1 object instantiated from the Reserve Account Class
            // Minimum 1 object instantiated from the Savings Account Class


            //Other Required Tasks

            // Use StreamWriter to create account summary files that track transactions for each account type(each type has its own text file).Files should be located in the Debug Folder and should include:
            StreamWriter report = new StreamWriter("..\\..\\numbers.txt");

            using (report)
            {
                // Name of Client
                report.WriteLine("Transaction History for " + clientName + "\n");
                // Client Account Number
                report.WriteLine();
                // Account Type(Checking, Reserve, or Savings)
                // Each transaction should be on its own line
                // Each transaction should show date and time of transaction(must use DateTime Class)
                // Each transaction should show a “+” for deposit and a “-” for withdrawal
                // Each transaction should show the transaction amount
                // Each transaction should show the new current balance after the transaction
            }
        }
    }
}
