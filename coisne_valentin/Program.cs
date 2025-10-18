using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            BirthDate = new DateTime(1990, 1, 1)
        };
        Person person2 = new Person
        {
            FirstName = "Jane",
            LastName = "Smith",
            BirthDate = new DateTime(1995, 5, 5)
        };
        CurrentAccount account1 = new CurrentAccount("BE14-0634-9455-6354", 1000.0, 500.0, person1);
        CurrentAccount account2 = new CurrentAccount("BE14-0634-5549-6355", 2000.0, 1000.0, person1);

        Console.WriteLine($"Name: {person1.FirstName} {person1.LastName}, Birth Date: {person1.BirthDate.ToShortDateString()}");
        Console.WriteLine($"Name: {person2.FirstName} {person2.LastName}, Birth Date: {person2.BirthDate.ToShortDateString()}");
        Console.WriteLine($"Account Number: {account1.Number}, Balance: {account1.Balance}, Credit Line: {account1.creditLine}");
        Console.WriteLine($"Account Number: {account2.Number}, Balance: {account2.Balance}, Credit Line: {account2.creditLine}");
         Bank bnp = new Bank(new Dictionary<string, CurrentAccount>(), "Ma Banque");
        bnp.AddAccount(account1);
        bnp.AddAccount(account2);
        bnp.GetAccountsInfo(person1);
        bnp.DeleteAccount(account1);
        bnp.GetAccountsInfo(person1);
        bnp.GetAccountsInfo(person2);
    }
}