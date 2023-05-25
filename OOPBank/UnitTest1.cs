
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
        [ExpectedException(typeof(Exception),"Balance too low")]
        public void Withdraw_over_Checking_Savings_Balance_under_ten()
        {
            decimal withdraw_amount = 8000;
            Customer customer = new Customer(4000, 3000);
            customer.Withdraw(withdraw_amount);
            //Assert.AreEqual(0, customer.SavingsBalance);
        }
        [TestMethod]
        public void DepositPassCustomer()
        {
            decimal deposit_amount = 695;
            Customer customer = new Customer(4000, 3000);
            customer.Deposit(deposit_amount);
            Assert.AreEqual(customer.Balance, deposit_amount + 3000);
        }
        [TestMethod]
        public void CheckingDeposit()
        {
            decimal deposit_amount = 695;
            Checking checking = new Checking (0);
            checking.Deposit(deposit_amount);
            Assert.AreEqual(checking.Balance, deposit_amount);
        }
        [TestMethod]
        public void CheckingWithdraw()
        {
            decimal Withdraw_amount = 695;
            Checking checking = new Checking(Withdraw_amount);
            checking.Withdraw(Withdraw_amount);
            Assert.AreEqual(checking.Balance, 0);
        }
        [TestMethod]
        public void SavingsWithdraw()
        {
            decimal Withdraw_amount = 695;
            Savings savings = new Savings(Withdraw_amount);
            savings.Withdraw(Withdraw_amount);
            Assert.AreEqual(savings.Balance, 0);
        }
        public void SavingsDeposit()
        {
            decimal deposit_amount = 695;
            Savings savings = new Savings(deposit_amount);
            savings.Deposit(deposit_amount);
            Assert.AreEqual(savings.Balance, deposit_amount);            
        }
    }
}