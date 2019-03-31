using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console
{
    class SavingsAccount : Account
    {

        public SavingsAccount(int id, string firstName, string lastName, long pesel)
            : base(id, firstName, lastName, pesel)      //konstruktor klasy bazowej
        {
        }

        public override string TypeName()
        {
            return "OSZCZĘDNOŚCIOWE";
        }

    }
}
