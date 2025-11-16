using System;
using System.Collections.Generic; 
class Bank
{
    public string Name { get; set; }
    public Dictionary<string, Account> Accounts { get; private set; }

    public Bank(string name)
    {
        Name = name;
        Accounts = new Dictionary<string, Account>();
    }

    public void AddAccount(Account account)
    {
        if (Accounts.ContainsKey(account.Number))
        {
            Console.WriteLine($"Le compte {account.Number} existe déjà.");
            return;
        }

        Accounts.Add(account.Number, account);
        Console.WriteLine($"Le compte {account.Number} a été ajouté pour {account.Owner.FirstName} {account.Owner.LastName}.");
    }

    public void DeleteAccount(string number)
    {
        if (!Accounts.ContainsKey(number))
        {
            Console.WriteLine($"Le compte {number} n'existe pas.");
            return;
        }

        Accounts.Remove(number);
        Console.WriteLine($"Le compte {number} a été supprimé.");
    }

    public double GetAccountBalance(string number)
    {
        if (!Accounts.TryGetValue(number, out Account account))
        {
            Console.WriteLine($"Le compte {number} n'existe pas.");
            return 0;
        }

        Console.WriteLine($"Le solde du compte {number} est de {account.Balance}.");
        return account.Balance;
    }

    public double GetTotalBalance(Person owner)
    {
        double totalBalance = 0;

        foreach (var account in Accounts.Values)
        {
            if (account.Owner == owner)
            {
                totalBalance += account.Balance;
            }
        }

        Console.WriteLine($"Le solde total pour {owner.FirstName} {owner.LastName} est de {totalBalance}.");
        return totalBalance;
    }
}