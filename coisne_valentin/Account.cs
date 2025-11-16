using System;

abstract class Account
{
    public string Number { get; set; }
    public double Balance { get; private set; }
    public Person Owner { get; set; }

    protected Account(string number, Person owner)
    {
        Number = number;
        Owner = owner;
        Balance = 0;
    }

    protected void ChangeBalance(double amount)
    {
        Balance += amount;
    }

    public virtual void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Le montant doit être positif");
            return;
        }

        ChangeBalance(amount);
        Console.WriteLine($"Dépôt de {amount}, solde disponible {Balance}");
    }

    public abstract void Withdraw(double amount);

    protected abstract double CalculInterets();

    public void ApplyInterest()
    {
        double interets = CalculInterets();
        ChangeBalance(interets);
        Console.WriteLine($"Application des intérêts de {interets}. Nouveau solde : {Balance}");
    }
}