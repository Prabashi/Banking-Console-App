using System;
namespace BankingApp.Models
{
    public class InterestRule : IInterestRule
    {
        public DateOnly Date { get; private set; }
        public string Id { get; private set; }
        public float Rate { get; private set; }

        public InterestRule()
        {
        }
    }
}

