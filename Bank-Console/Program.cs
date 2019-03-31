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

            List<Account> accounts = new List<Account>();

            accounts.Add(new SavingsAccount(1, "Marek", "Zajac", 1234567890));
            accounts.Add(new SavingsAccount(2, "Marek", "Aaaa", 1234554321));
            accounts.Add(new SavingsAccount(3, "Zzzz", "Bbb", 0987654321));
            accounts.Add(new BillingAccount(4, "Marek", "Zajac", 1234567890));
            accounts.Add(new BillingAccount(5, "Marek", "Aaaa", 1234554321));

            Printer printer = new Printer();

            printer.Print(accounts[1]);
            printer.Print(accounts[4]);

            Console.ReadKey();




















            Console.ReadKey();
        }
    }
}
