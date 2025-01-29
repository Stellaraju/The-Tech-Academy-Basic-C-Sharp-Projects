using System;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        // 1. Concatenate three strings
        string str1 = "Hello, ";
        string str2 = "this is ";
        string str3 = "a concatenated string!";

        // Concatenate the strings and print the result
        string concatenatedString = str1 + str2 + str3;
        Console.WriteLine("Concatenated String: " + concatenatedString);

        // 2. Convert a string to uppercase
        string originalString = "this will be converted to uppercase.";

        // Convert the string to uppercase and print the result
        string uppercaseString = originalString.ToUpper();
        Console.WriteLine("Uppercase String: " + uppercaseString);

        // 3. Use StringBuilder to build a paragraph of text
        StringBuilder paragraph = new StringBuilder();

        // Add sentences one at a time
        paragraph.AppendLine("Once upon a time, there was a little girl named Red.");
        paragraph.AppendLine("She lived in a village near the forest.");
        paragraph.AppendLine("One day, she decided to visit her grandmother's house.");
        paragraph.AppendLine("On her way, she met a big, bad wolf!");

        // Print the built paragraph
        Console.WriteLine("\nParagraph Built with StringBuilder: ");
        Console.WriteLine(paragraph.ToString());

        // Keep the console window open
        Console.ReadLine();
    }
}