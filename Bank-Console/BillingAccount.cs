using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console
{
    class BillingAccount : Account
    {
     
        public BillingAccount(string accountNumber, decimal balance, string firstName, string lastName, long pesel)
            : base(accountNumber, balance, firstName, lastName, pesel)      //konstruktor klasy bazowej
        {            
        }

        public override string TypeName()
        {
            return "ROZLICZENIOWE";
        }
    }
}
