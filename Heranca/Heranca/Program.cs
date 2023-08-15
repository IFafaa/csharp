using Heranca.Entities;
using Heranca.Entities.NovaPasta;
using System;

namespace Heranca
{
    internal class Program {
        static void Main(string[] args) {
            /*
               Account acc = new Account(1001, "Alex", 0);
            BusinessAcount bacc = new BusinessAcount(1001, "Alex", 0, 5000);

            // Upcasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAcount(2322, "Pedro", 0.0, 200);
            Account acc3 = new SavingsAccount(2322, "Pedro", 0.0, 0.01);

            //Downcasting

            BusinessAcount acc4 = (BusinessAcount)acc2;

            if(acc3 is BusinessAcount) {
                BusinessAcount acc5 = (BusinessAcount)acc3;
                acc5.Loan(1000);
                Console.WriteLine("Loan!");
            }
            if(acc3 is SavingsAccount) {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.updateBalance();
                Console.WriteLine("Updated!");
            }
             */


            Account acc1 = new BusinessAcount(101, "Alex", 500, 2000);
            Account acc2 = new SavingsAccount(1001, "Pedro", 1000, 0.01);

            acc1.WithDraw(10);
            acc2.WithDraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}