﻿using System;
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


        //Minimum 1 constructor
        public Savings(string acctType, int acctNum, decimal balance, decimal intRate) : base(acctType, acctNum, balance, intRate)
        {
        }
    }
}
