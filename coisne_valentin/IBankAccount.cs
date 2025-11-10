public interface IBankAccount
{
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
    void ApplyInterest(decimal interestRate);
    string Owner { get;}
    string AccountNumber { get;}
}