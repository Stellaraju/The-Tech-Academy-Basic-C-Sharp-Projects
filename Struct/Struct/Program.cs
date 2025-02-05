using System;

namespace StructExample
{
    // Define a struct called "Number"
    public struct Number
    {
        // Define a property called "Amount" of type decimal
        public decimal Amount { get; set; }

        // Constructor for the Number struct to initialize the Amount property
        public Number(decimal amount)
        {
            Amount = amount; // Initialize the Amount property with the provided value
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Number struct and assign a value to the Amount property
            Number myNumber = new Number(100.50m); // Assign 100.50 to the Amount property

            // Print the Amount to the console
            Console.WriteLine("The amount is: " + myNumber.Amount); // Output the value of the Amount property
            Console.ReadLine();
        }
    }
}