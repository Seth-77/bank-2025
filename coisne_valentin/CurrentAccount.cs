using System;


class CurrentAccount
{
    public string Number { get; set; }
    public double Balance { get; private set; }
    public double CreditLine { get; set; }
    public Person Owner { get; set; }

    public CurrentAccount(string number, double creditLine, Person owner)
    {
        Number = number;
        CreditLine = creditLine;
        Owner = owner;
        Balance = 0;
    }

    public void Withdraw(double amount)
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

        Balance -= amount;
        Console.WriteLine($"Retrait de {amount}, solde disponible {Balance}");
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant doit être positif");
            return;
        }

        Balance += amount;
        Console.WriteLine($"Dépôt de {amount}, solde disponible {Balance}");
    }
}