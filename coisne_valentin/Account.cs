using System;

class Account(string number, double balance, Person owner)
{
    public string Number { get; set; } = number;
    public double Balance { get; private set; } = balance;
    public Person Owner { get; private set; } = owner;

    public virtual void withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Solde insufisant");
        }

        else
        {
            Balance -= amount;
        }
    }

    public virtual void deposit(double amount)
    {
        Balance += amount;
    }
}