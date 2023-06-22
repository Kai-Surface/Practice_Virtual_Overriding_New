using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Virtual_Overriding_New
{
    internal class RetirementAccount : SavingsAccount
    {
        public RetirementAccount(double interest, string name, decimal balance) : base(interest, name, balance)
        {
        }

        public override bool Withdraw(double amount)
        {
            Console.WriteLine("Cannot withdraw from a retirement account");
            return false;
        }
    }
}
