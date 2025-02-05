using System;


public class Employee
{
    // Properties for Id, FirstName, and LastName
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloading the "==" operator to compare Employee objects by their Id
    public static bool operator ==(Employee e1, Employee e2)
    {
        // If both references are the same, they are equal
        if (ReferenceEquals(e1, e2))
        {
            return true;
        }

        // If either object is null, they are not equal
        if (e1 is null || e2 is null)
        {
            return false;
        }

        // Compare the Id properties of both Employee objects
        return e1.Id == e2.Id;
    }

    // Overloading the "!=" operator to compare Employee objects by their Id
    public static bool operator !=(Employee e1, Employee e2)
    {
        // The "!=" operator is the negation of the "==" operator
        return !(e1 == e2);
    }

    // Override Equals to ensure consistency with "==" and "!="
    public override bool Equals(object obj)
    {
        // Ensure that the object is an Employee and compare by Id
        if (obj is Employee employee)
        {
            return this.Id == employee.Id;
        }
        return false;
    }

    // Override GetHashCode for consistency with Equals
    public override int GetHashCode()
    {
        // Use the Id property to calculate the hash code for the object
        return Id.GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the first Employee object and assign values to its properties
        Employee employee1 = new Employee
        {
            Id = 1,               // Assign Id to the first employee
            FirstName = "John",    // Assign FirstName to the first employee
            LastName = "Doe"       // Assign LastName to the first employee
        };

        // Instantiate the second Employee object and assign values to its properties
        Employee employee2 = new Employee
        {
            Id = 1,               // Assign the same Id to the second employee (same as employee1)
            FirstName = "Jane",    // Assign FirstName to the second employee
            LastName = "Smith"     // Assign LastName to the second employee
        };

        // Compare the two Employee objects using the overloaded "==" operator
        if (employee1 == employee2)
        {
            // If they are equal, print this message
            Console.WriteLine("Both employees are equal (based on their Id).");
        }
        else
        {
            // If they are not equal, print this message
            Console.WriteLine("The employees are not equal (based on their Id).");
            
        }

        // Compare the two Employee objects using the overloaded "!=" operator
        if (employee1 != employee2)
        {
            // If they are not equal, print this message
            Console.WriteLine("The employees are not equal (based on their Id).");
            Console.ReadLine();
        }
        else
        {
            // If they are equal, print this message
            Console.WriteLine("Both employees are equal (based on their Id).");
            Console.ReadLine();
        }
    }
}