﻿using System;
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
                            Console.WriteLine("Here are your account balances, {1}.", shillingRich);
                            shillingRich.ViewBalance(richChecking);
                            shillingRich.ViewBalance(richReserve);
                            shillingRich.ViewBalance(richSavings);
                        }
                        break;
                    case "3": //Deposit Funds
                        shillingRich.Deposit();
                        break;
                    case "4": //Withdraw Funds
                        shillingRich.Withdraw();
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
