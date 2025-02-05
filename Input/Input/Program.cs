using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Please enter a number: ");
        string userInput = Console.ReadLine();

        // Attempt to convert the input to a valid number
        if (int.TryParse(userInput, out int number))
        {
            // Define the path to the text file
            string filePath = "numberLog.txt";

            // Write the number to the text file
            File.WriteAllText(filePath, number.ToString());

            // Print a message confirming the number was logged
            Console.WriteLine("Your number has been logged to the file.");

            // Read the contents of the file and display it to the user
            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine("Here is the number from the file: " + fileContents);
        }
       
        else
        {
            // If the input was not a valid number
            Console.WriteLine("Please enter a valid number.");
        }
        Console.ReadLine();
    }
}
