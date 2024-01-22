namespace BankingApp.Models
{
    public interface IAccount
    {
        string Name { get; }
        List<Transaction> transactions { get; }
    }
}