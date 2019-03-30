using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console
{
    abstract class Account      // klasa abstrakcyjna oznacza ze nie mozemy w glownej klasie tworzyc obiektow z niej
    {
        public string AccountNumber;        // Wczesniej to wszystko bylo w klasie savings i billing, zastosowalem tu dziedziczenie
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;

        public Account(string accountNumber, decimal balance, string firstName, string lastName, long pesel)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
        }

        public abstract string TypeName();

        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public string GetBalance()
        {
            return string.Format("{0}", Balance);
        }
    }    
}
