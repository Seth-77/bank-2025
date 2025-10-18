using System;

class SavingsAccount(string number, double Balance, DateTime DateLastWithdraw, Person Owner)
{
    public string Number { get; set; } = number;
    public double Balance { get; private set; } = Balance;
    public DateTime DateLastWithdraw { get; private set; } = DateLastWithdraw;
    public Person Owner { get; private set; } = Owner;

    public void withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Solde insufisant");
        }

        else
        {
            Balance -= amount;
            DateLastWithdraw = DateTime.Now;
        }
    }
    public void deposit(double amount)
    {
        Balance += amount;
    }
}