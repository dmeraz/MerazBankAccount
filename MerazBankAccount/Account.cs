using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MerazBankAccount
{
    /*abstract*/
    class Account
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

        //StreamWriter
        protected StreamWriter checkHistory;
        protected StreamWriter resHistory;
        protected StreamWriter savHistory;

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
        public string AcctType
        {
            get
            {
                return this.acctType;
            }
        }
        public int AcctNum
        {
            get
            {
                return this.acctNum;
            }
        }
        public double AcctBalance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        //constructor
        public Account(string clientName)
        {
            this.clientName = clientName;
        }

        public Account(string acctType, int acctNum, double balance, double intRate)
        {
            this.acctType = acctType;
            this.acctNum = acctNum;
            this.balance = balance;
            this.intRate = intRate;
        }

        //methods

        //Add view client info method
        public void ViewClient()
        {
            Console.WriteLine("Client name: " + ClientInfo);
        }

        //Add view account balances method
        public void ViewBalance()
        {
            Console.WriteLine(AcctType + ": " + AcctBalance);
        }

        //Attempted to initiate new StreamWriter object here

        //Add withdrawl method
        public virtual void Withdraw()
        {
            Console.WriteLine("Please enter an amount to withdraw from your account.");
            double amount = double.Parse(Console.ReadLine());

            AcctBalance = AcctBalance - amount;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Enjoy your money. You now have " + AcctBalance + " in your account.");

            //Continue override method here
        }

        //Add deposit method
        public virtual void Deposit()
        {
            Console.WriteLine("Please enter an amount to deposit into your account.");
            double amount = double.Parse(Console.ReadLine());

            AcctBalance = AcctBalance + amount;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("We'll keep this safe. You now have " + AcctBalance + " in your account.");

            //Continue override method here
        }

        //Add exit method
        public void Exit()
        {
            Console.WriteLine("Thank you for choosing Future Investments Bank.\nWe'll keep your money safe.");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }

        //Menu
        public void Menu()
        {
            //Client services
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

        //Account Menu
        public void AccountMenu()
        {
            Console.WriteLine("Please select an account.\n");
            Console.WriteLine("   a. Checking Account Balance");
            Console.WriteLine("   b. Reserve Account Balance");
            Console.WriteLine("   c. Savings Account Balance");
        }

    }
}
