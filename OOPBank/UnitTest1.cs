
using BankUnitTest_Gabriel;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace OOPBank
{
    [TestClass]
    public class OOPBank
    {

        Customer customer = new Customer(3000,4000);
        [TestMethod]
        public void CheckingBalancePass()
        {
            decimal _checkingBalance = 3000;
            decimal _savingsBalance = 4000;
            Customer customer = new Customer(4000, 3000);
            Assert.AreEqual(_checkingBalance, customer.Balance);
        }
        [TestMethod]
        public void Withdraw()
        {
            decimal _checkingBalance = 3000;
            decimal withdraw_amount = 500;
            Customer customer = new Customer(4000, 3000);
            customer.Withdraw(withdraw_amount);
            Assert.AreEqual(_checkingBalance- withdraw_amount, customer.Balance);
        }
        [TestMethod]
        public void Withdraw_over_Checking_Zero_Balance()
        {
            decimal withdraw_amount = 4000;
            Customer customer = new Customer(4000, 3000);
            customer.Withdraw(withdraw_amount);
            Assert.AreEqual(0, customer.Balance);
        }
        [TestMethod]
        public void Withdraw_over_Checking_Savings_Balance()
        {
            decimal withdraw_amount = 4000;
            Customer customer = new Customer(4000, 3000);
            customer.Withdraw(withdraw_amount);
            Assert.AreEqual(3000, customer.SavingsBalance);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Balance too low")]
        public void Withdraw_over_Checking_Savings_Balance_under_ten()
        {
            decimal withdraw_amount = 8000;
            Customer customer = new Customer(4000, 3000);
            customer.Withdraw(withdraw_amount);
            //Assert.AreEqual(0, customer.SavingsBalance);
        }
    }
}