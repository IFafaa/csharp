using System;
using TaxPayerExercise.Entities;
using System.Globalization;

namespace TaxPayerExercise
{
    internal class Program {
        static void Main(string[] args) {
            List<Person> persons = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int qtdPersons = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdPersons; i++) {
                Console.WriteLine($"\nTax payer #{i + 1} data:");

                Console.Write("Individual or company (i/c): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if(ch == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    persons.Add(new PhysicalPerson(healthExpenditures, name, anualIncome));
                }
                else {
                    Console.Write("Number of employees: ");
                    int employeesQtd = int.Parse(Console.ReadLine());
                    persons.Add(new LegalPerson(employeesQtd, name, anualIncome));
                }
            }

            Console.WriteLine("\n\nTAXES PAID:");
            double totalTax = 0;
            foreach (Person person in persons) {
                Console.WriteLine(person.ToString());
                totalTax += person.totalTax();
            }

            Console.WriteLine($"\n\nTOTAL TAXES: $ {totalTax}");

        }
    }
}