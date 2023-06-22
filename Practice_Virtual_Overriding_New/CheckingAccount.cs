using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_New
{
    internal class CheckingAccount : BankAccount
    {
        double _overdraftFee;

        public CheckingAccount(double overdraftFee, string name, decimal balance) : base(name, balance)
        {
            OverdraftFee = overdraftFee;
        }

        public double OverdraftFee { get => _overdraftFee; set => _overdraftFee = value; }

        public override bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Balance -= OverdraftFee;
            }
            return true;
        }

        public override string ToString()
        {
            string baseString = base.ToString();
            return $"{baseString} - Overdraft Fee: {_overdraftFee}";
        }
    }
}
