using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArranjosVetores {
    internal class Produto {

        public string Name { get; set; }
        public double Preco { get; set; }

        public Produto(string name, double preco) {
            Name = name;
            Preco = preco;
        }
    }
}
