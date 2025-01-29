using System;


class Program
{
    static void Main(string[] args)
    {
        // Print an introductory message to the console
        Console.WriteLine("Boolean Comparison with While and Do-While Loop");

        // Initialize some boolean variables for comparison
        bool condition1 = true;
        bool condition2 = false;

        // 1. Boolean comparison with a while statement
        // We will check if condition1 is true and run the loop until it becomes false
        while (condition1)
        {
            // Print the result of the comparison to the console
            Console.WriteLine("While Loop: Condition1 is true");

            // Change condition1 to false so the loop stops after the first iteration
            condition1 = false;
        }

        // 2. Boolean comparison with a do-while statement
        // We will check if condition2 is false and run the loop at least once
        do
        {
            // Print the result of the comparison to the console
            Console.WriteLine("Do-While Loop: Condition2 is false");

            // Change condition2 to true so the loop will stop after the first iteration
            condition2 = true;

        } while (condition2 == false); // The loop will stop because condition2 is now true

        // Print a message to indicate the end of the program
        Console.WriteLine("Program has finished.");

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}