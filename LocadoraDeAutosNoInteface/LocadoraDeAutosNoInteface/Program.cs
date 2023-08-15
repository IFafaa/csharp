using LocadoraDeAutosNoInteface.Entities;
using LocadoraDeAutosNoInteface.Services;
using System;
using System.Globalization;

namespace LocadoraDeAutosNoInteface {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter rental data:");

            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice.ToString());

        }
    }
}