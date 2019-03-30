using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nazwa: Bank";
            string author = "Autor: Mateusz Drzyzga";
            Console.WriteLine(name);
            Console.WriteLine(author);
            Console.WriteLine();
           
            Printer printer = new Printer();
           

            Account account;
            
            account = new SavingsAccount("940000000001", 0.0M, "Mateusz", "Drzyzga", 95031206855);
            printer.Print(account);
            
            account = new BillingAccount("940000000002", 0.0M, "Mateusz", "Drzyzga", 95031206855);
            printer.Print(account);

            Console.WriteLine("Pierwsze konto w systemie dostał(-a): {0}", account.GetFullName());














            Console.ReadKey();
        }
    }
}
