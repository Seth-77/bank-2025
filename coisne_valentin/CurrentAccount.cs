using System;


class CurrentAccount(string number, double Balance, double creditLine, Person owner)
{
    public string Number { get; set; } = number;
    public double Balance { get; set; } = Balance;
    public double creditLine { get; set; } = creditLine;
    public Person owner { get; set; } = owner;

    public void withdraw(double amount)
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
    public void deposit(double amount)
    {
        Balance += amount;
    }

    

}