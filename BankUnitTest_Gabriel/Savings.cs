using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUnitTest_Gabriel
{
    internal class Savings: IAccount
    {
        private static decimal _balance;

        public Savings(decimal balance)
        {
            _balance = balance;
        }
        public decimal Balance => CheckBallance(_balance);
        public decimal CheckBallance(decimal balance)
        {
            return balance;
        }
        public void Deposit(decimal amount)
        {
            _balance = _balance + amount;
        }
        public void Withdraw(decimal amount)
        {
            _balance = _balance - amount;
        }
    }
}

