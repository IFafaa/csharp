﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFuncionariosHeranca.Entities {
    internal class OutsourceEmployee: Employee {

        public double AdditionalCharge  { get; set; }
        private double AdditionalChargeTax { get; set; } = 110/100;
        public OutsourceEmployee() { }
        public OutsourceEmployee(string name, int hours, double valuePerHour ,double additionalCharge)
            :base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() {
            return base.Payment() + AdditionalCharge * AdditionalChargeTax;
        }
    }
}
