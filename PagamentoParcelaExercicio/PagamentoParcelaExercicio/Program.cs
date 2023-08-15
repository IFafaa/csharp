using PagamentoParcelaExercicio.Entities;
using PagamentoParcelaExercicio.Services;
using System;

namespace PagamentoParcelaExercicio {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);
            PaymentService paymentService = new PaymentService(new PaypalTaxService());
            paymentService.ProcessInstallments(contract, numberOfInstallments);

            Console.WriteLine("\n\nInstallments:");
            contract.Installment.ForEach((installment) => {
                Console.WriteLine(installment.ToString());
            });
        }
    }
}