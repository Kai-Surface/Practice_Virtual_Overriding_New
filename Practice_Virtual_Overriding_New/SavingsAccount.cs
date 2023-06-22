using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_New
{
    internal class SavingsAccount : BankAccount
    {
        double _interest;

        public SavingsAccount(double interest, string name, decimal balance) : base(name, balance)
        {
            Interest = interest;
        }

        public double Interest { get => _interest; set => _interest = value; }

        public override bool Deposit(double _amount)
        {
            bool _depositSuccessful = base.Deposit(_amount);

            if (_depositSuccessful)
            {
                Balance += Interest; 
            }

            return _depositSuccessful;
        }

        public override string ToString()
        {
            string baseString = base.ToString();
            return $"{baseString} - Interest: {_interest}";
        }
    }
}
