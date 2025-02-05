using System;

class Program
{
    static void Main(string[] args)
    {
        // Print the current date and time
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine("Current Date and Time: " + currentDateTime);

        // Ask the user for a number (X)
        Console.Write("Please enter a number (X) of hours: ");
        string userInput = Console.ReadLine();

        // Attempt to convert the input to an integer
        if (int.TryParse(userInput, out int hoursToAdd))
        {
            // Calculate the time X hours from now
            DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);

            // Print the new date and time after adding X hours
            Console.WriteLine("In " + hoursToAdd + " hours, it will be: " + futureDateTime);
        }
        else
        {
            // If the input is not a valid number, display an error message

            Console.WriteLine("Please enter a valid number for the hours.");
            

        }
        Console.ReadLine();

    }
}