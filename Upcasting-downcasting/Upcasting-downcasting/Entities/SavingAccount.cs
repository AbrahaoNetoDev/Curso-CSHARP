using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_downcasting.Entities
{
    sealed class SavingAccount : Account
    {
        public double InteresRate { get; set; }

        public SavingAccount()
        {

        }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InteresRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InteresRate;
        }

        public override void Withdraw(double amount) // Uma sobrescrita do metodo na Account
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
