using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            BirthDate = new DateTime(1990, 1, 1)
        };

        Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Birth Date: {person.BirthDate.ToShortDateString()}");
    }
}   