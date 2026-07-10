using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting_e_donwcasting.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account ()
        {

        }

        public Account (int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw (double ammount)
        {
            Balance -= ammount;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }
    }
}
