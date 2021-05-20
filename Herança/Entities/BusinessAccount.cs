using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Entities {
    class BusinessAccount : Account { // BusinessAccount herda tudo que tem na Account

        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) { // chamando o construtor da classe account com a palavra "base" e já atrbui os valores do construtor
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) {
            if (amount <= LoanLimit) {
                Balance += amount;
            }
        } 
    }
}
