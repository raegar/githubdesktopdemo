using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Mrs A", 1000M);
            string input = "£100";
            decimal amount = Convert.ToDecimal(input);
            account1.Debit(amount);
        }
    }
}
