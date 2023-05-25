using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUnitTest_Gabriel
{
    public class Checking : IAccount
    {
        private static decimal _balance;
        public Checking(decimal balance)
        {
            _balance = balance;
        }

        public decimal Balance => _balance;

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
