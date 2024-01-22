namespace BankingApp.Models
{
    public interface ITransaction
    {
        DateOnly Date { get; }
        string Type { get; }
        float Amount { get; }
    }
}