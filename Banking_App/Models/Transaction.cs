using System;
namespace BankingApp.Models
{
    public class Transaction : ITransaction
    {
        public DateOnly Date { get; private set; }
        public string Type { get; private set; }
        public float Amount { get; private set; }

        public Transaction()
        {
        }
    }
}

