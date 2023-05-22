using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUnitTest_Gabriel
{
    public class Customer : IAccount
    {
        private static decimal _savingsBalance;
        private static decimal _checkingBalance;
    public Customer(decimal savingsBalance, decimal checkingBalance)
        {
            _checkingBalance = checkingBalance;
            _savingsBalance = savingsBalance;
        }
        Savings savings = new Savings(_savingsBalance);
        Checking checking = new Checking(_checkingBalance);

        public decimal Balance => CheckBallance(_checkingBalance);
        public decimal SavingsBalance => _savingsBalance;
        public decimal CheckBallance(decimal balance)
        {
            return balance;
        }
        public void Deposit(decimal amount)
        {
            _checkingBalance = _checkingBalance + amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= _checkingBalance)
            {
                _checkingBalance -= amount;
            }
            //savings must have 10.00
        
            if (amount > _checkingBalance && amount <= (_checkingBalance + _savingsBalance - 10))
            {
               decimal savingsAmount = amount - _checkingBalance;
                _savingsBalance -= savingsAmount;
                _checkingBalance = 0;
            } 
            if (amount < _checkingBalance && amount <= (_checkingBalance + _savingsBalance - 10))
            {
               
                throw new Exception("Balance too low");
            }

        }
    }
}
