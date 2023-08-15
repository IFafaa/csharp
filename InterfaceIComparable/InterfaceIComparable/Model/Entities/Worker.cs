using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIComparable.Model.Entities {
    internal class Worker: IComparable {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Worker(string csvEmployee) {
            string[] line = csvEmployee.Split(",");
            Name = line[0];
            Salary = double.Parse(line[1]);
        }

        public override string ToString() {
            return Name + " - " + Salary;
        }

        public int CompareTo(object? obj) {
            if(!(obj is Worker)) {
                throw new ArgumentException("Comparing error: argument is not worker");
            }
            Worker other = obj as Worker;
            return Salary.CompareTo(other.Salary);
        }
    }
}
