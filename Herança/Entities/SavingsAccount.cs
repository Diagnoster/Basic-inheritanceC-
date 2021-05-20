using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Entities {
     class SavingsAccount : Account { // herda tudo que a classe account tem

        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) { // override -> sobrescrita da classe withdraw
            base.Withdraw(amount); // reaproveita a operaçao da superclasse
            Balance -= 2.0;
        }
    }
}
