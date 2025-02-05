using System;

namespace EnumExample
{
    // Define an enum for the days of the week
    public enum DayOfWeek
    {
        Sunday,    // Sunday is represented by 0
        Monday,    // Monday is represented by 1
        Tuesday,   // Tuesday is represented by 2
        Wednesday, // Wednesday is represented by 3
        Thursday,  // Thursday is represented by 4
        Friday,    // Friday is represented by 5
        Saturday   // Saturday is represented by 6
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week (e.g., Monday):");

            try
            {
                // Read the user input as a string
                string userInput = Console.ReadLine();

                // Convert the input string to a DayOfWeek enum
                // We use Enum.TryParse to safely attempt the conversion
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userInput, true);

                // Output the converted enum value
                Console.WriteLine($"You selected: {day}");
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                // Catch the exception if the input is not a valid day of the week
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
    }
}