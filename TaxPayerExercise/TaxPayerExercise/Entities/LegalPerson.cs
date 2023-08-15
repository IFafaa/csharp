using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerExercise.Entities {
    internal class LegalPerson: Person {
        public int EmployeesQtd { get; private set; }
        public LegalPerson(int employeesQtd, string name, double anualIncome)
        :base(name,anualIncome)
        {
            EmployeesQtd = employeesQtd;
        }
        public override double totalTax() {
            double tax = (EmployeesQtd > 10) ? 14.0/100 : 16.0/100;
            return AnualIncome * tax;
        }
    }
}
