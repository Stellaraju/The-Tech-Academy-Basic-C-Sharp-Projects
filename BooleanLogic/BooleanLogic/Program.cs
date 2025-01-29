using System;


class Program
{
    static void Main()
    {
        // Print the program title
        Console.WriteLine("Car Insurance Qualification Program");

        // Ask for the applicant's age
        Console.Write("What is your age? ");
        int age = int.Parse(Console.ReadLine());

        // Ask if the applicant has had a DUI
        Console.Write("Have you ever had a DUI? (true/false) ");
        bool hasDUI = bool.Parse(Console.ReadLine());

        // Ask how many speeding tickets the applicant has
        Console.Write("How many speeding tickets do you have? ");
        int speedingTickets = int.Parse(Console.ReadLine());

        // Check the qualification criteria
        bool qualifies = (age > 15 && !hasDUI && speedingTickets <= 3);

        // Print the result
        Console.WriteLine("Qualification result: " + qualifies);
        Console.ReadLine();
    }
}