using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosControleSistema {
    internal class Funcionario {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario) { 
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void aumentarSalario(double percentage) {
            Salario += Salario * (percentage / 100);
        }
        public override string ToString() {
            return $"{Id} - {Nome}, ${Salario}";
        }
    }
}
