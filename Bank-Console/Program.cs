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
            AccountsManager manager = new AccountsManager();

            manager.CreateBillingAccount("Mateusz", "Drzyzga", 1234567890);
            manager.CreateSavingsAccount("Mateusz", "Drzyzga", 1234567890);
            manager.CreateSavingsAccount("Aaaaa", "Bbbbb", 0987654321);

            IList<Account> accounts = (IList<Account>)manager.GetAllAccounts();

            Printer printer = new Printer();

            printer.Print(accounts[0]);
            printer.Print(accounts[2]);

            Console.ReadKey();            
        }
    }
}
