namespace BankingApp.Models
{
    public interface IInterestRule
    {
        DateOnly Date { get; }
        string Id { get; }
        float Rate { get; }
    }
}