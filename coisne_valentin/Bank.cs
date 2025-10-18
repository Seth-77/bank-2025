using System;
using System.Collections.Generic;
using System.Numerics;

class Bank(Dictionary<string, CurrentAccount> accounts, string name)
{
    public Dictionary<string, CurrentAccount> Accounts { get; private set; } = accounts;
    public string Name { get; set; } = name;

    public void AddAccount(CurrentAccount account)
    {
        if (Accounts.ContainsKey(account.Number))
        {
            Console.WriteLine("Ce compte existe déjà !");
        }
        else
        {
            Accounts.Add(account.Number, account);
        }
    }
    public void DeleteAccount(CurrentAccount account)
    {
        if (Accounts.ContainsKey(account.Number))
        {
            Accounts.Remove(account.Number);
            Console.WriteLine("Compte supprimer");
        }
        else
        {
            Console.WriteLine("Compte inexistant !");
        }
    }
    public void GetBalance(string number)
    {
        if (Accounts.ContainsKey(number))
        {
            Console.WriteLine($"Le solde du compte {number} est de {Accounts[number].Balance} ");
        }
        else
        {
            Console.WriteLine("Compte inexistant !");

        }
    }

    public void GetAccountsInfo(Person user)
    {
        double totalBalance = 0;
        bool hasAccount = false;
        foreach (CurrentAccount account in Accounts.Values)
        {
            if (account.owner == user)
            {
                Console.WriteLine($"Compte n°{account.Number} : Solde = {account.Balance}, Ligne de crédit = {account.creditLine}");
                totalBalance += account.Balance;
                hasAccount = true;
            }
        }
        if (!hasAccount)
        {
            Console.WriteLine("Cet utilisateur n'a pas de compte dans cette banque.");
        }
        else
        {
            Console.WriteLine($"Solde total pour {user.FirstName} {user.LastName} : {totalBalance}");
        }

    }


}