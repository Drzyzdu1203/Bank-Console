using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console
{
    class Printer : IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Dane konta: {0}", account.AccountNumber);
            Console.WriteLine("Typ konta: {0}", account.TypeName());
            Console.WriteLine("Saldo: {0}zł", account.GetBalance());
            Console.WriteLine("Imię i zazwisko właściciela: {0}", account.GetFullName());          
            Console.WriteLine("PESEL właściciela: {0}", account.Pesel);
            Console.WriteLine();
        }        
    }
}
