using ContractsDepartment.Entities;
using ContractsDepartment.Entities.Enums;
using System;

namespace ContractsDepartment
{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Entre com o nome do departamento: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Entre com os dados do trabalhador:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (JUNIOR / MID_LEVEL / SENIOR): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department department = new Department(departmentName);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("Quantos contratos estão associados a esse trabalhador: ");
            int qtdContract = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdContract; i++) {
                Console.WriteLine($"#{i + 1} - Dados do contrato:");

                Console.Write("Data (DD/MM/YYYY): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                int valuePerHour = int.Parse(Console.ReadLine());

                Console.Write("Quantidade de horas: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(dateContract, valuePerHour, hours);
                worker.AddContract(hourContract);
            }

            Console.WriteLine("\n----------------------------------------------------------\n");

            Console.Write("Insira o mês e o ano para calcular os ganhos (MM/YYYY): ");
            string dateTxt = Console.ReadLine();
            int month = int.Parse(dateTxt.Substring(0, 2));
            int year = int.Parse(dateTxt.Substring(3));

            double income = worker.Income(year, month);

            Console.WriteLine($"Nome: {worker.Name}");
            Console.WriteLine($"Departamento: {worker.Department.Name}");
            Console.WriteLine($"Ganhos do período {month}/{year}: ${income}");

        }
    }
}