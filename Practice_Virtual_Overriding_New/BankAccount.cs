using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_New
{
    internal class BankAccount
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

        public virtual bool Deposit (double _amount)
        {
            if (_amount < 0)
            {
                return false;
            }

            _balance += _amount;
            return true;
        }

        public virtual bool Withdraw (double _amount)
        {
            if (_amount < 0 || _amount > _balance)
            {
                return false;
            }

            _balance -= _amount;
            return true;
        }

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
