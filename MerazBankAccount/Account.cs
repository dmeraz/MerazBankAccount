using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerazBankAccount
{
    class Account
    {
        //fields

        //Client Info
        string clientName = "Shilling Rich";
        //add address and telephone later

        //Account Info
        string acctType;
        int acctNum;
        decimal balance;
        decimal intRate;

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
        public decimal AcctBalance
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
        public Account(string acctType, int acctNum, decimal balance, decimal intRate)
        {
            this.acctType = acctType;
            this.acctNum = acctNum;
            this.balance = balance;
            this.intRate = intRate;
        }

        //method

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
