using System;

class Program
{
    static void Main()
    {
        // Task 1: Takes an input from the user, multiplies it by 50, then prints the result
        Console.Write("Enter a number to multiply by 50: ");
        double num1 = Convert.ToDouble(Console.ReadLine());  // Convert user input to a double
        double result1 = num1 * 50;  // Multiply the input by 50
        Console.WriteLine($"The result of multiplying by 50 is: {result1}");  // Print the result

        // Task 2: Takes an input from the user, adds 25 to it, then prints the result
        Console.Write("Enter a number to add 25 to it: ");
        double num2 = Convert.ToDouble(Console.ReadLine());  // Convert user input to a double
        double result2 = num2 + 25;  // Add 25 to the input
        Console.WriteLine($"The result of adding 25 is: {result2}");  // Print the result

        // Task 3: Takes an input from the user, divides it by 12.5, then prints the result
        Console.Write("Enter a number to divide by 12.5: ");
        double num3 = Convert.ToDouble(Console.ReadLine());  // Convert user input to a double
        double result3 = num3 / 12.5;  // Divide the input by 12.5
        Console.WriteLine($"The result of dividing by 12.5 is: {result3}");  // Print the result

        // Task 4: Takes an input from the user, checks if it is greater than 50, then prints true/false result
        Console.Write("Enter a number to check if it's greater than 50: ");
        double num4 = Convert.ToDouble(Console.ReadLine());  // Convert user input to a double
        bool isGreaterThan50 = num4 > 50;  // Check if the number is greater than 50
        Console.WriteLine($"Is the number greater than 50? {isGreaterThan50}");  // Print true or false

        // Task 5: Takes an input from the user, divides it by 7, then prints the remainder
        Console.Write("Enter a number to divide by 7 and get the remainder: ");
        double num5 = Convert.ToDouble(Console.ReadLine());  // Convert user input to a double
        double remainder = num5 % 7;  // Calculate the remainder when divided by 7 using the modulus operator
        Console.WriteLine($"The remainder when divided by 7 is: {remainder}");  // Print the remainder
        Console.ReadLine();
    }
}