using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MerazBankAccount
{
    class Reserve : Account
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
        public Reserve(string acctType, int acctNum, double balance, double intRate) : base(acctType, acctNum, balance, intRate)
        {
        }

        public Reserve(string acctType, int acctNum, double balance, double intRate, string nickname, bool cashback) : base(acctType, acctNum, balance, intRate)
        {

        }

        //Override Withdraw Method
        public override void Withdraw()
        {
            Console.WriteLine("Please enter an amount to withdraw from your account.");
            double amount = double.Parse(Console.ReadLine());

            AcctBalance = AcctBalance - amount;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Enjoy your money. You now have " + AcctBalance + " in your account.");

            resHistory = new StreamWriter("resHistory.txt", true);
            {
                resHistory.WriteLine("Transaction History for " + ClientInfo + "\n");
                resHistory.WriteLine("Account number: " + AcctNum);
                resHistory.WriteLine("Account type: " + AcctType);
                resHistory.WriteLine(DateTime.Now + " - " + amount + " " + AcctBalance + "\n");
            }
            resHistory.Close();
        }
    }
}
