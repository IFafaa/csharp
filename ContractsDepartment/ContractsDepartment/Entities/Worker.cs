using ContractsDepartment.Entities.Enums;
using System;

namespace ContractsDepartment.Entities {
    internal class Worker {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();
        public Department Department { get; set; }


        public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) {  
            Contracts.Remove(contract); 
        }

        public double Income(int year, int month) {
            List<HourContract> contractsFiltered;

            contractsFiltered = Contracts.FindAll(contract => contract.Date.Year == year && contract.Date.Month == month);

            double totalValue = BaseSalary;

            contractsFiltered.ForEach(contract =>
            {
                totalValue += contract.TotalValue();
            });

            return totalValue;
        }
    }
}
