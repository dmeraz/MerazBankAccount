using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerazBankAccount
{
    class Savings: Account
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
    }
}
