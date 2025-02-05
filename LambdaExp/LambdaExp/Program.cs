using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeExample
{
    // Define the Employee class with Id, FirstName, and LastName properties
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to easily create Employee objects
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee(1, "Joe", "Smith"),
                new Employee(2, "Sarah", "Johnson"),
                new Employee(3, "Joe", "Davis"),
                new Employee(4, "Anna", "Brown"),
                new Employee(5, "David", "Miller"),
                new Employee(6, "Emily", "Taylor"),
                new Employee(7, "Daniel", "Anderson"),
                new Employee(8, "Sophia", "Thomas"),
                new Employee(9, "James", "Moore"),
                new Employee(10, "John", "Jackson")
            };

            // Using foreach loop to create a new list of employees with the first name "Joe"
            List<Employee> joeEmployees = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joeEmployees.Add(employee); // Add employee to the new list if the first name is "Joe"
                }
            }

            // Print the list of employees with the first name "Joe"
            Console.WriteLine("Employees with the first name 'Joe' (using foreach loop):");
            foreach (var employee in joeEmployees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - Id: {employee.Id}");
            }

            // Using a lambda expression to create a new list of employees with the first name "Joe"
            var joeEmployeesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Print the list of employees with the first name "Joe" using a lambda expression
            Console.WriteLine("\nEmployees with the first name 'Joe' (using lambda expression):");
            foreach (var employee in joeEmployeesLambda)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - Id: {employee.Id}");
            }

            // Using a lambda expression to create a list of all employees with Id greater than 5
            var employeesWithIdGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

            // Print the list of employees with Id greater than 5
            Console.WriteLine("\nEmployees with Id greater than 5 (using lambda expression):");
            foreach (var employee in employeesWithIdGreaterThanFive)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - Id: {employee.Id}");
                Console.ReadLine();
            }
        }
    }
}
