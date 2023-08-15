using System.Globalization;

namespace TaxPayerExercise.Entities {
    abstract class Person {
        public string Name { get; set; }
        public double AnualIncome { get; private set; }

        public Person(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double totalTax();

        public override string ToString() {
            return $"{Name}: $ {totalTax().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
