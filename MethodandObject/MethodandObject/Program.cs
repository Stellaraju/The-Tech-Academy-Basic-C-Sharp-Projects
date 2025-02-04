using System;

public class Person
{
    // Properties for First Name and Last Name
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Method to print full name
    public void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

public class Employee : Person
{
    // Additional property for Employee ID
    public int Id { get; set; }
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

        // Call SayName() method from the Person class
        employee.SayName();
        Console.ReadLine();
    }
}
