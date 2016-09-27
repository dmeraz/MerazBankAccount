using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MerazBankAccount
{
    class Checking : Account //Inherits Account base class
    {
        //Minimum 2 fields
        string nickname;
        bool cashback;


        //Minimum 2 properties
        public string Rename
        {
            get
            {
                return this.nickname;
            }
            set
            {
                this.nickname = value;
            }
        }

        public bool Rewards
        {
            get
            {
                return this.cashback;
            }
            set
            {
                this.cashback = value;
            }
        }


        //Minimum 1 constructor 
        public Checking(string acctType, int acctNum, double balance, double intRate) : base(acctType, acctNum, balance, intRate)
        {
        }

        public Checking(string acctType, int acctNum, double balance, double intRate, string nickname, bool cashback) : base(acctType, acctNum, balance, intRate)
        {

        }


        //Methods

        //Override withdrawl method
        public override void Withdraw()
        {
            Console.WriteLine("Please enter an amount to withdraw from your account.");
            double amount = double.Parse(Console.ReadLine());

            AcctBalance = AcctBalance - amount;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Enjoy your money. You now have $" + AcctBalance + " in your account.");

            checkHistory = new StreamWriter("checkHistory.txt", true);
            {
                checkHistory.WriteLine("Transaction History for " + ClientInfo + "\n");
                checkHistory.WriteLine("Account number: " + AcctNum);
                checkHistory.WriteLine("Account type: " + AcctType);
                checkHistory.WriteLine(DateTime.Now + " - $" + amount + " $" + AcctBalance + "\n");
            }
            checkHistory.Close();
        }

        //Ovverride deposit method
        public override void Deposit()
        {
            Console.WriteLine("Please enter an amount to deposit into your account.");
            double amount = double.Parse(Console.ReadLine());

            AcctBalance = AcctBalance + amount;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("We'll keep this safe. You now have $" + AcctBalance + " in your account.");

            checkHistory = new StreamWriter("checkHistory.txt", true);
            {
                checkHistory.WriteLine("Transaction History for " + ClientInfo + "\n");
                checkHistory.WriteLine("Account number: " + AcctNum);
                checkHistory.WriteLine("Account type: " + AcctType);
                checkHistory.WriteLine(DateTime.Now + " + $" + amount + " $" + AcctBalance + "\n");
            }
            checkHistory.Close();
        }
    }
}
