using System;

class SavingsAccount : Account
{
    public DateTime DateLastWithdraw { get; private set; }

    public SavingsAccount(string number, Person owner)
        : base(number, owner)
    {
        DateLastWithdraw = DateTime.MinValue;
    }

    public override void Withdraw(double amount)
    {   
        if (amount <= 0)
        {
            Console.WriteLine("Le montant doit être positif");
            return;
        }
        if (amount > Balance)
        {
            Console.WriteLine("Solde insuffisant");
            return;
        }

        ChangeBalance(-amount);
        DateLastWithdraw = DateTime.Now;
        Console.WriteLine($"Retrait de {amount}, solde disponible {Balance}");
    }

    public override void Deposit(double amount)
    {
        base.Deposit(amount);
    }

    protected override double CalculInterets()
    {
        return Balance * 0.045;
    }
}