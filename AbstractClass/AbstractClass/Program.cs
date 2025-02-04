using System;

public abstract class Person
{
    // Properties for First Name and Last Name
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Abstract method SayName() - to be implemented in derived classes
    public abstract void SayName();
}

public class Employee : Person
{
    // Implement the SayName method
    public override void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate an Employee object with sample names
        Employee employee = new Employee
        {
            FirstName = "Stellamary",
            LastName = "Assirvatham"
        };

        // Call the SayName method
        employee.SayName();
        Console.ReadLine();
    }
}