using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversorDolar {
    internal class Conversor {
        private static double Taxa = 6;
        public static double valorDaTaxa(double valor) {
            return valor * Taxa / 100;
        }

        public static double conversorRealDolar(double quantidade, double cotacao) {
            return (quantidade * cotacao);
        }
    }
}
