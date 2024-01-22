using System;
namespace BankingApp.Models;

public class Account : IAccount
{
    public string Name { get; private set; }
    public List<Transaction> transactions { get; private set; }

}

