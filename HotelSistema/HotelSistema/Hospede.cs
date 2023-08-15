using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSistema {
    internal class Hospede {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Cpf { get; private set; }


        public Hospede(string name, string email, string cpf) { 
            Name = name;
            Email = email;
            Cpf = cpf;
        }

        public override string ToString() {
            return $"{Name}, {Email}";
        }
    }
}
