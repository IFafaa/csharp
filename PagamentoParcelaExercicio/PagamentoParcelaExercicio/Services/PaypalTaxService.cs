using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoParcelaExercicio.Services {
    internal class PaypalTaxService: ITaxService {
        public double Tax(double amount) {
            return amount * 0.02;
        }
    }
}
