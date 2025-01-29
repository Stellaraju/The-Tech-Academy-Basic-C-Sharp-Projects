using System;


class Program
{
    static void Main()
    {
        // Print welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.Write("Enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the package is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;  // Exit the program if the weight is too heavy
        }

        // Prompt user for package dimensions
        Console.Write("Enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the total dimensions are too big
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;  // Exit the program if the dimensions total is greater than 50
        }

        // Calculate the quote
        double quote = (width * height * length * weight) / 100;

        // Display the quote to the user
        Console.WriteLine("Your shipping quote is: $" + quote);
        Console.ReadLine();
    }
}