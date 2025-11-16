using System;


class CurrentAccount : Account
{
    public double CreditLine { get; set; }

    public CurrentAccount(string number, double creditLine, Person owner)
        : base(number, owner)
    {
        CreditLine = creditLine;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant doit être positif");
            return;
        }

        if (Balance - amount < -CreditLine)
        {
            Console.WriteLine("Pas assez d'argent (limite de crédit atteinte)");
            return;
        }

        ChangeBalance(-amount);
        Console.WriteLine($"Retrait de {amount}, solde disponible {Balance}");
    }

    protected override double CalculInterets()
    {
        if (Balance > 0)
        {
            return Balance * 0.03;
        }
        return Balance * 0.0975;
    }
}