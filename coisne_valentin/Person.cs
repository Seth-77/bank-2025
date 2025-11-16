using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthdate { get; set; }

    public Person(string firstName, string lastName, DateTime birthdate)
    {
        FirstName = firstName;
        LastName = lastName;
        Birthdate = birthdate;
    }
}