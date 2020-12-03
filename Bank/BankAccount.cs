using System;


namespace Bank
{
    public class BankAccount
    {
        private string customerName;

        private decimal balance;

        private bool frozen = false;

        private BankAccount()
        {
        }

        public BankAccount(string customerName, decimal balance)
        {
            this.customerName = customerName;
            this.balance = balance;
        }

        public string CustomerName
        {
            get { return customerName; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Debit(decimal amount)
        {
            if (frozen)
            {
                throw new Exception("Account frozen");
            }

            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            balance -= amount; // intentionally incorrect code
        }

        public void Credit(decimal amount)
        {
            if (frozen)
            {
                throw new Exception("Account frozen");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            balance += amount;
        }

        private void FreezeAccount()
        {
            frozen = true;
        }

        private void UnfreezeAccount()
        {
            frozen = false;
        }
    }
}
