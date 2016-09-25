﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerazBankAccount
{
     /*abstract*/ class Account
    {
        //fields

        //Client Info
        string clientName = "Shilling Rich";
        //add address and telephone later

        //Account Info
        private string acctType;
        private int acctNum;
        private double balance;
        private double intRate;

        //properties
        public string ClientInfo
        {
            get
            {
                return this.clientName;
            }
            set
            {
                this.clientName = "Shilling Rich";
            }
        }
        public double AcctBalance
        {
            get
            {
                return this.balance;
            }
            //Most banks only allow you to view balance or Withdraw/Deposit
            //Withdraw/Deposit should be methods that alter the property
            //set
            //{
            //    this.balance = value;
            //}
        }

        //constructor
        public Account(string acctType, int acctNum, double balance, double intRate)
        {
            this.acctType = acctType;
            this.acctNum = acctNum;
            this.balance = balance;
            this.intRate = intRate;
        }

        //methods
        //Add withdrawl method
        public void Withdraw()
        {
            Console.WriteLine("Please enter an amount to withdraw from your account.");
            double amount = double.Parse(Console.ReadLine());

            double newbalance = balance - amount;//might not need to create new variable
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Enjoy your money. You now have {1} in your account.", newbalance);
        }

        //Add deposit method
        public void Deposit()
        {
            Console.WriteLine("Please enter an amount to deposit into your account.");
            double amount = double.Parse(Console.ReadLine());

            double newbalance = balance + amount;//might not need to create new variable
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("We'll keep this safe. You now have {1} in your account.", newbalance);
        }

    //Menu
    public void Menu()
        {
            //ScoreBoard();
            Console.WriteLine("Please select a menu item.\n");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("   a. Checking Account Balance");
            Console.WriteLine("   b. Reserve Account Balance");
            Console.WriteLine("   c. Savings Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
        }
    }
}
