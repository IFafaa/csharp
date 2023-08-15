using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;      

namespace exercicioContaBancaria {
    internal class ContaBancaria {
        private int _taxa = 5;
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) {
            Numero = numero;
            Titular = titular;
            Depositar(depositoInicial);
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public void Sacar(double valor) {
            Saldo = (Saldo - valor) - _taxa;
        }

        public override string ToString() {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: ${Saldo.ToString("F2")}";
        }
    }
}
