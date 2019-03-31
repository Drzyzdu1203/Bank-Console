using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console
{
    abstract class Account      // klasa abstrakcyjna oznacza ze nie mozemy w glownej klasie tworzyc obiektow z niej
    {
        public int Id;
        public string AccountNumber;        // Wczesniej to wszystko bylo w klasie savings i billing, zastosowalem tu dziedziczenie
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;

        public Account(int id, string firstName, string lastName, long pesel)
        {
            Id = id;
            AccountNumber = generateAccountNumber(id);
            Balance = 0.0M;
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

        private string generateAccountNumber(int id)        // generowanie numeru konta do ogarniecia.
        {
            var accountNumber = string.Format("94{0:D10}", Id);

            return accountNumber;
        }
    }    
}
