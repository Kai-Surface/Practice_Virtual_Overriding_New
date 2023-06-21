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

        public static void Withdraw(double amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
            }
            else
            {
                _balance -= _overdraftFee;
            }
        }

        public override string ToString()
        {
            string baseString = base.ToString();
            return $"{baseString} - Overdraft Fee: {_overdraftFee}";
        }
    }
}
