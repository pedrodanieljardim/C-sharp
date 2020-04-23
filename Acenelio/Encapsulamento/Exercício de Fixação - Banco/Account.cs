using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Account
    {
        public int numberAccount;
        public String nameTitular;
        public double balance;

        Account(int numberAccount, String nameTitular, double initialDeposit)
        {
            this.numberAccount = numberAccount;
            this.nameTitular = nameTitular;
            this.balance = initialDeposit;
        }

        // Set

        public void setNumberAccount(int numberAccount)
        {
            this.numberAccount = numberAccount;
        }

        public void setnameTitular(String nameTitular)
        {
            this.nameTitular = nameTitular;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        // Get

        public int getNumberAccount()
        {
            return this.numberAccount;
        }

        public String getnameTitular()
        {
            return this.nameTitular;
        }

        public double getBalance()
        {
            return this.balance;
        }

        public void depositAccount(double deposit)
        {
            if(deposit > 0)
            {
                this.balance += deposit;
            }
        }
        public void withdrawAccount(double withdraw)
        {
            if (this.balance >= withdraw)
            {
                this.balance -= withdraw;
            }
        }


        public override string ToString()
        {
            return $"Conta: {this.numberAccount}, Titular: {this.nameTitular}, Saldo:  + {this.getBalance()}";
        }


    }

}
