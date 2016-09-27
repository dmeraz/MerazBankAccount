using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MerazBankAccount
{
    class Savings : Account
    {
        //Inherits Account base class
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
        public Savings(string acctType, int acctNum, double balance, double intRate) : base(acctType, acctNum, balance, intRate)
        {
        }

        public Savings(string acctType, int acctNum, double balance, double intRate, string nickname, bool cashback) : base(acctType, acctNum, balance, intRate)
        {

        }

        //Override withdrawl method
        public override void Withdraw()
        {
            Console.WriteLine("Please enter an amount to withdraw from your account.");
            double amount = double.Parse(Console.ReadLine());

            AcctBalance = AcctBalance - amount;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Enjoy your money. You now have $" + AcctBalance + " in your account.");

            savHistory = new StreamWriter("savHistory.txt", true);
            {
                savHistory.WriteLine("Transaction History for " + ClientInfo + "\n");
                savHistory.WriteLine("Account number: " + AcctNum);
                savHistory.WriteLine("Account type: " + AcctType);
                savHistory.WriteLine(DateTime.Now + " - $" + amount + " $" + AcctBalance + "\n");
            }
            savHistory.Close();
        }

        //Override deposit method
        public override void Deposit()
        {
            Console.WriteLine("Please enter an amount to deposit into your account.");
            double amount = double.Parse(Console.ReadLine());

            AcctBalance = AcctBalance + amount;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("We'll keep this safe. You now have $" + AcctBalance + " in your account.");

            savHistory = new StreamWriter("savHistory.txt", true);
            {
                savHistory.WriteLine("Transaction History for " + ClientInfo + "\n");
                savHistory.WriteLine("Account number: " + AcctNum);
                savHistory.WriteLine("Account type: " + AcctType);
                savHistory.WriteLine(DateTime.Now + " + $" + amount + " $" + AcctBalance + "\n");
            }
            savHistory.Close();
        }
    }
}
