using BankAccountWithExceptions.Entities;
using BankAccountWithExceptions.Entities.Exceptions;
using System;

namespace BankAccountWithExceptions
{
    internal class Program {
        static void Main(string[] args) {
            Account acc = new Account();

            try {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine("\nEnter amount for withdraw: ");
                double amountWithdraw = double.Parse(Console.ReadLine());
                acc.Withdraw(amountWithdraw);
                Console.WriteLine("New balance: " + acc.Balance);
            }
            catch(DomainException ex) {
                Console.WriteLine("\n-----------------------------------------------------------\nWITHDRAW ERROR: " + ex.Message);
            }
            catch(FormatException ex) {
                Console.WriteLine("\n-----------------------------------------------------------\nFORMAT ERROR: " + ex.Message);
            }
            catch (Exception ex) {
                Console.WriteLine("\n-----------------------------------------------------------\nUNEXPECTED ERROR: " + ex.Message);

            }
        }
    }
}