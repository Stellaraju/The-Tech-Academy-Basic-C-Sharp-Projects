using System;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Ask the user for their age
            Console.Write("Please enter your age: ");
            string userInput = Console.ReadLine();

            // Attempt to parse the input to an integer
            if (int.TryParse(userInput, out int age))
            {
                // Check if the age is zero or negative
                if (age <= 0)
                {
                    Console.WriteLine("Error: Age must be a positive number greater than zero.");
                }
                else
                {
                    // Calculate the year the user was born (assuming the current year is 2025)
                    int currentYear = DateTime.Now.Year;
                    int birthYear = currentYear - age;

                    // Display the year the user was born
                    Console.WriteLine("You were born in the year: " + birthYear);
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number for your age.");
            }
        }
        catch (Exception ex)
        {
            // Catch any other unexpected errors
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        Console.ReadLine();
    }
}