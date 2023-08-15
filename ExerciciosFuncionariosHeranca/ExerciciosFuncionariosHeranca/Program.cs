using ExerciciosFuncionariosHeranca.Entities;
using System;

namespace ExercicioFuncionariosHeranca
{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of employees: ");
            int qtdEmployees = int.Parse(Console.ReadLine());

            List<Employee> Employees = new List<Employee>();
            for (int i = 0; i < qtdEmployees; i++) {
                Console.WriteLine($"\nEmployee #{i + 1} data:");

                Console.Write("Outsourced (y/n): ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if(outsourced == 'y') {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    Employees.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else {
                    Employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("\n\n\nPayments: ");
            foreach (Employee employee in Employees) {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}