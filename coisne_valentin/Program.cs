using System;
class Program
{
    static void Main(string[] args)
    {
        Person valentin = new Person("Valentin", "Dupont", new DateTime(1990, 5, 15));
        CurrentAccount account1 = new CurrentAccount("FR123456789", 500, valentin);
        CurrentAccount account2 = new CurrentAccount("FR234567890", 500, valentin);

        Bank myBank = new Bank("Ma Banque");
        myBank.AddAccount(account1);
        myBank.AddAccount(account2);

        account1.Deposit(1000);
        account1.Withdraw(200);
        account2.Deposit(5000);
        account2.Withdraw(1400);

        myBank.DeleteAccount("FR123456789");
        myBank.AddAccount(account1);

        myBank.GetTotalBalance(valentin);
        myBank.GetAccountBalance("FR123456789");
        myBank.GetAccountBalance("FR234567890");

        Console.ReadLine();
    }
}
