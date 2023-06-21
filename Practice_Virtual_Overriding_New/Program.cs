using System;

namespace Practice_Virtual_Overriding_New
{
    class Program
    {

        static void Main(string[] args)
        {
            List<BankAccount> _accounts = new List<BankAccount>();

            SavingsAccount _savingsAccount = new SavingsAccount("Savings Account", 2222, 0.02);
            CheckingAccount _checkingAccount = new CheckingAccount("Checking Account", 2000, 2);
            RetirementAccount _retirementAccount = new RetirementAccount("Retirement Account", 100000, 5);

            _accounts.Add(_savingsAccount);
            _accounts.Add(_checkingAccount);
            _accounts.Add(_retirementAccount);

            foreach (BankAccount _account in _accounts)
            {
                Console.WriteLine($"Account: {_account.Name}");
                Console.WriteLine($"Initial Balance: {_account.Balance}");

                // deposit $500
                _account.Deposit(500);
                Console.WriteLine($"Deposit: 500");
                Console.WriteLine($"New Balance: {_account.Balance}");

                // deposit -$50,000
                _account.Deposit(-50000);
                Console.WriteLine($"Deposit: -50000");
                Console.WriteLine($"New Balance: {_account.Balance}");

                // withdraw $200
                _account.Withdraw(200);
                Console.WriteLine($"Withdraw: 200");
                Console.WriteLine($"New Balance: {_account.Balance}");

                // withdraw -$200,000
                _account.Withdraw(-200000);
                Console.WriteLine($"Withdraw: -200000");
                Console.WriteLine($"New Balance: {_account.Balance}");

                // overdraw the account
                _account.Withdraw(_account.Balance + 100);
                Console.WriteLine($"Attempted Overdraw");
                Console.WriteLine($"New Balance: {_account.Balance}");

                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}