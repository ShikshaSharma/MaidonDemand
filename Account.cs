using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Account
    {
        private readonly int AccountID;
        private String AccountHolder;
        private double bal;

        public Account()
        {
            AccountID = 0;
            AccountHolder = null;
            bal = 0;
        }

        public Account(int AccountID, String AccountHolder, double bal)
        {
            this.AccountID = AccountID;
            this.AccountHolder = AccountHolder;
            this.bal = bal;
        }

        public void withdraw(double amount)
        {
            bal = bal - amount;
        }

        public void deposit(double amount)
        {
            bal = bal + amount;
        }

        public double Bal
        {
            get 
            {
                return this.bal;
            }
            set
            {
                this.Bal = bal;
            }
        }

        public String getAccountHolder()
        {
            return AccountHolder;
        }
      
        public int getAccountID()
        {
            return AccountID;
        }
        //new changes ny manish
        public override string ToString()
        {
            return "New account balance = " + Bal;
        }
    }
}
