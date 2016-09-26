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
            Console.WriteLine("Welcome to Future Investments Bank.");

            //Objects

            // Minimum 1 object instantiated from the Checking Account Class
            // Insert Checking constructor with parameters
            Checking richChecking = new Checking("checking", 0123456789, 300.00, .01, "Everyday Rich", true);

            // Minimum 1 object instantiated from the Reserve Account 
            // Insert Reserve constructor with parameters
            Reserve richReserve = new Reserve("reserve", 0123456789, 50, .00);

            // Minimum 1 object instantiated from the Savings Account Class
            // Insert Savings constructor with parameters
            Savings richSavings = new Savings("savings", 0123456789, 1000.00, .05);

            //Create client
            Account shillingRich = new Account("Shilling Rich");

            //These will write files, but won't track anything, details at end of class
            //StreamWriter checkHistory = new StreamWriter("checkHistory.txt");
            //using (checkHistory)
            //{
            //    checkHistory.WriteLine("Transaction History for " + shillingRich.ClientInfo + "\n");
            //    checkHistory.WriteLine("Account number: " + richChecking.AcctNum);
            //    checkHistory.WriteLine("Account type: " + richChecking.AcctType);
            //    checkHistory.WriteLine(DateTime.Now + " +/- " + " amount " + richChecking.AcctBalance + "\n");
            //}

            //Methods
            do
            {
                shillingRich.Menu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": //View Client Information
                        shillingRich.ViewClient();
                        break;
                    case "2": //View Account Balance
                        {
                            Console.WriteLine("Here are your account balances, " + shillingRich.ClientInfo + ".");
                            richChecking.ViewBalance();
                            richReserve.ViewBalance();
                            richSavings.ViewBalance();
                        }
                        break;
                    case "3": //Deposit Funds
                        richChecking.Deposit();
                        break;
                    case "4": //Withdraw Funds
                        richChecking.Withdraw();
                        break;
                    case "5": //Exit
                        shillingRich.Exit();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            }
            while (true);


            //Other Required Tasks

            //Use StreamWriter to create account summary files that track transactions for each account type
            //(each type has its own text file)

            //Files should be located in the Debug Folder and should include:
            //    // Name of Client
            //    // Client Account Number
            //    // Account Type(Checking, Reserve, or Savings)
            //    // Each transaction should be on its own line
            //    // Each transaction should show date and time of transaction(must use DateTime Class)
            //    // Each transaction should show a “+” for deposit and a “-” for withdrawal
            //    // Each transaction should show the transaction amount
            //    // Each transaction should show the new current balance after the transaction

 
            //StreamWriter resHistory = new StreamWriter("resHistory.txt");
            //using (resHistory)
            //{
            //    checkHistory.WriteLine("Transaction History for " + shillingRich.ClientInfo + "\n");
            //    checkHistory.WriteLine("Account number: " + richReserve.AcctNum);
            //    checkHistory.WriteLine("Account type: " + richReserve.AcctType);
            //    checkHistory.WriteLine(DateTime.Now + " +/- " + " amount " + richReserve.AcctBalance + "\n");
            //}

            //StreamWriter savHistory = new StreamWriter("savHistory.txt");
            //using (savHistory)
            //{
            //    checkHistory.WriteLine("Transaction History for " + shillingRich.ClientInfo + "\n");
            //    checkHistory.WriteLine("Account number: " + richSavings.AcctNum);
            //    checkHistory.WriteLine("Account type: " + richSavings.AcctType);
            //    checkHistory.WriteLine(DateTime.Now + " +/- " + " amount " + richSavings.AcctBalance + "\n");
            //}


            //Notes Regarding StreamWriter

            //StreamWriter code was not reachable here.
            //Attempted move to into switch-case.
            //This prevented more than one menu task from being selected in a single session. 
            //Attempted to move StreamWriter into Account class.
            //This did not allow the program to run.
            //Prior to StreamWriter becoming unreachable code,
            //which seemed to have something to do with the do-while class,
            //checkHistory.txt was produced.

            //Once checkHistory works:
            //Add deposit and withdraw methods for reserve and savings account

        }
    }
}
