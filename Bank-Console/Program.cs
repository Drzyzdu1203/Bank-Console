﻿using System;
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
            
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.Init("940000000001", 0.0M, "Mateusz" , "Drzyzga", 95031206855);
                     
            SavingsAccount savingsAccount2 = new SavingsAccount();
            savingsAccount2.Init("940000000002", 0.0M, "Mateusz", "Drzyzga", 95031206855);

            BillingAccount billingAccount = new BillingAccount();
            billingAccount.Init("940000000003", 0.0M, "Mateusz", "Drzyzga", 95031206855);

            Printer printer = new Printer();
            printer.Print(savingsAccount);
            printer.Print(savingsAccount2);

            printer.Print(billingAccount);
            Console.ReadKey();
        }
    }
}
