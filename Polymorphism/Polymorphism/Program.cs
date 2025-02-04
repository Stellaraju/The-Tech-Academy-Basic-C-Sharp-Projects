using System;


public abstract class Person
{
    // Properties for first and last name, to be shared by all derived classes
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Abstract method SayName() that will be implemented by derived classes
    public abstract void SayName();
}

public interface IQuittable
{
    // The Quit method, which any class that implements IQuittable must define
    void Quit();
}

public class Employee : Person, IQuittable
{
    // Implementing the abstract method SayName() from Person class
    public override void SayName()
    {
        // Print the full name (FirstName + LastName)
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }

    // Implementing the Quit() method from IQuittable interface
    public void Quit()
    {
        // Here we simply print a message that indicates the employee is quitting
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate an Employee object and set its properties
        Employee employee = new Employee
        {
            FirstName = "Stellamary",  // Set FirstName property
            LastName = "Assirvatham"   // Set LastName property
        };

        // Call the SayName() method on the Employee object to print the name
        employee.SayName();

        // Polymorphism: Create an IQuittable reference to an Employee object
        IQuittable quittableEmployee = employee;

        // Call the Quit() method through the IQuittable interface reference
        quittableEmployee.Quit();  // This will invoke the Quit() method in Employee
        Console.ReadLine();
    }
}