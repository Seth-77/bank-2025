using System;
class Program
{
    static void Main(string[] args)
    {
        Person valentin = new Person("Valentin", "Dupont", new DateTime(1990, 5, 15));

        CurrentAccount account1 = new CurrentAccount("FR123456789", 500, valentin);
        CurrentAccount account2 = new CurrentAccount("FR234567890", 500, valentin);
        SavingsAccount savingsAccount = new SavingsAccount("FR345678901", valentin);

        Bank myBank = new Bank("Ma Banque");

        myBank.AddAccount(account1);
        myBank.AddAccount(account2);
        myBank.AddAccount(savingsAccount);

        account1.Deposit(1000);
        account1.Withdraw(200);

        account2.Deposit(5000);
        account2.Withdraw(1400);

        savingsAccount.Deposit(2000);
        savingsAccount.Withdraw(500);

        account1.ApplyInterest();
        savingsAccount.ApplyInterest();

        Console.ReadLine();
    }
}
