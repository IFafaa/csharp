﻿using BankAccountWithExceptions.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountWithExceptions.Entities {
    internal class Account {
        public int Number { get; private set; }
        public string Holder{ get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
            Deposit(balance);
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount) {
            if(amount > WithdrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if(amount > Balance) {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }
    }
}