using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_New
{
    abstract class BankAccount
    {
        string _name;
        int _accountNumber;
        double _balance;

        public BankAccount(string name, double balance)
        {
            _name = name;
            _balance = balance;

            Random random = new Random();
            _accountNumber = random.Next(100000, 999999);
        }

        public string Name { get => _name; set => _name = value; }
        public int AccountNumber { get => _accountNumber; }
        public double Balance { get => _balance; }

        public abstract bool Deposit(double _amount);

        public abstract bool Withdraw(double _amount);

        public override string ToString()
        {
            return this.GetType($"Name: {_name} - Account number: {_accountNumber} - Balance: {_balance}");
        }

        private string GetType(string v)
        {
            throw new NotImplementedException();
        }
    }
}
