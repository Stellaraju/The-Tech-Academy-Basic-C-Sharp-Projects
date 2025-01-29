using System;


class Program
{
    static void Main()
    {
        // Print the program title to the console
        Console.WriteLine("Anonymous Income Comparison Program");

        // Collect data for Person 1
        Console.WriteLine("Person 1");

        // Ask for and store Person 1's hourly rate
        Console.Write("Enter the hourly rate for Person 1: ");
        double hourlyRate1 = Convert.ToDouble(Console.ReadLine());  // Convert user input to double

        // Ask for and store Person 1's hours worked per week
        Console.Write("Enter the hours worked per week for Person 1: ");
        double hoursWorked1 = Convert.ToDouble(Console.ReadLine());  // Convert user input to double

        // Collect data for Person 2
        Console.WriteLine("Person 2");

        // Ask for and store Person 2's hourly rate
        Console.Write("Enter the hourly rate for Person 2: ");
        double hourlyRate2 = Convert.ToDouble(Console.ReadLine());  // Convert user input to double

        // Ask for and store Person 2's hours worked per week
        Console.Write("Enter the hours worked per week for Person 2: ");
        double hoursWorked2 = Convert.ToDouble(Console.ReadLine());  // Convert user input to double

        // Calculate the annual salary for Person 1
        double annualSalary1 = hourlyRate1 * hoursWorked1 * 52;  // Multiply hourly rate, hours worked, and 52 weeks

        // Calculate the annual salary for Person 2
        double annualSalary2 = hourlyRate2 * hoursWorked2 * 52;  // Multiply hourly rate, hours worked, and 52 weeks

        // Print the annual salary of Person 1
        Console.WriteLine($"Annual salary of Person 1: {annualSalary1}");

        // Print the annual salary of Person 2
        Console.WriteLine($"Annual salary of Person 2: {annualSalary2}");

        // Compare the salaries and print the result
        bool person1MakesMore = annualSalary1 > annualSalary2;  // Check if Person 1 makes more money than Person 2
        Console.WriteLine($"Person 1 makes more money than Person 2: {person1MakesMore}");  // Print the result
        Console.ReadLine();
    }
}