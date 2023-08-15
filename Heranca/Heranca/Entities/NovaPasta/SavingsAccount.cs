using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities.NovaPasta {
    sealed class SavingsAccount: Account {
        public double InterestRate { get; private set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
        : base(number, holder, balance) 
        {
            InterestRate = interestRate;
        }

        public void updateBalance() {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount) {
            base.WithDraw(amount);
            Balance -= 2;
        }
    }
}
