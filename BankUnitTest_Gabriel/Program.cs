namespace BankUnitTest_Gabriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(3000, 2000);
            //Account account = new Account();
            bool IsRunning = true;
            string choice;

            void printMenu()
            {
                Console.WriteLine("Choose from the following options: ");
                Console.WriteLine("1. Deposit ");
                Console.WriteLine("2. Withdraw  ");
                Console.WriteLine("3. Check Balance ");
                Console.WriteLine("4. Exit Program ");
            }

            while (IsRunning)
            {
                printMenu();
                choice = Console.ReadLine();
               
                switch (choice)
                {
                    
                    case "1":
                        Console.WriteLine(" What is the Amount to Deposit? ");
                        decimal amountDeposit = decimal.Parse(Console.ReadLine());
                        
                        Console.WriteLine(String.Format("{0:C2}", amountDeposit) + " Deposited ");
                        Console.WriteLine(" Please make another selection ");
                        Console.WriteLine("");
                        customer.Deposit(amountDeposit);
                        break;
                    case "2":
                        Console.WriteLine(" What is the Amount to Withdraw?");
                        decimal amountWithdraw = decimal.Parse(Console.ReadLine());
                        Console.WriteLine(String.Format("{0:C2}",amountWithdraw) + " was withdrew ");
                        //add from what account 
                        customer.Withdraw(amountWithdraw);
                        Console.WriteLine(" Please make another selection ");
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine(" Check Balance ");
                        decimal CheckingBalannce = customer.Balance;
                        decimal savingsBalance = customer.SavingsBalance;
                        Console.WriteLine(" Checking has a balance of " + CheckingBalannce);   //+ add checking ballance);
                        // add check Balance both accounts
                       Console.WriteLine(" Savings has a balance of " + savingsBalance); //+ add Savings ballance);
                        Console.WriteLine(" Please make another selection ");
                        Console.WriteLine("");
                        break;
                    case "4":
                        Console.WriteLine(" Exit Program ");
                        Console.WriteLine("");
                        IsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Enter a number from the menu ");
                        break;
                }
            }
        }
    }    
}