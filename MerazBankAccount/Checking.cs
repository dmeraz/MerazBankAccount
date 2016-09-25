using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerazBankAccount
{
    class Checking : Account
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
        public Checking(string acctType, int acctNum, decimal balance, decimal intRate) : base(acctType, acctNum, balance, intRate)
        {
        }

        public Checking(string acctType, int acctNum, decimal balance, decimal intRate, string nickname, bool cashback) : base(acctType, acctNum, balance, intRate)
        {

        }
    }
}
