using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUnitTest_Gabriel
{
    internal class Account : IAccount
    {
        private decimal _balance;

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
