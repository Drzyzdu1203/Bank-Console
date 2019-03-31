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

            Account savingsAccount = new SavingsAccount(1, "Mateusz", "Drzyzga", 95031206855);
            Account savingsAccount2 = new SavingsAccount(2, "Mateusz", "Drzyzga", 95031206855);
            Account billingAccount = new BillingAccount(3 ,"Mateusz", "Drzyzga", 95031206855);

            Console.WriteLine("Pierwsze konto w systemie dostał(-a): {0}", savingsAccount.GetFullName());

            Printer printer = new Printer();

            printer.Print(savingsAccount);
            printer.Print(savingsAccount2);
            printer.Print(billingAccount);



















            Console.ReadKey();
        }
    }
}
