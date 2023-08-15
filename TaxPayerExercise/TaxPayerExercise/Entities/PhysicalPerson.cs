using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayerExercise.Entities {
    internal class PhysicalPerson: Person {
        public double HealthExpenditures { get; set; }

        public PhysicalPerson(double healthExpenditures, string name, double anualIncome)
        :base(name, anualIncome)
        { 
            HealthExpenditures = healthExpenditures;
        }
        public override double totalTax() {
            double taxHealthExpenditures = (HealthExpenditures > 0) ? HealthExpenditures * (50.0/100) : 0;
            if (AnualIncome < 20000) {
                return AnualIncome * (15.0/100) - taxHealthExpenditures;
            }
            else {
                return AnualIncome * (25.0/100) - taxHealthExpenditures;
            }
        }
    }
}
