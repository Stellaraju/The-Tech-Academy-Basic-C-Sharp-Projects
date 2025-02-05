using System;
using System.IO;


class Program
{
    // Create a const variable
    const double Pi = 3.14159; // Pi is a constant, its value cannot be changed once assigned.

    static void Main(string[] args)
    {
        // Create a variable using the 'var' keyword
        var message = "Hello, this is a message!"; // 'var' is used for implicit typing based on the assigned value.

        // Print the const variable and the 'var' variable to the console
        Console.WriteLine("Value of Pi: " + Pi);
        Console.WriteLine("Message: " + message);

        // Chain two constructors together (using constructor overloading)
        MyClass obj = new MyClass("First constructor", 10);  // Calls the constructor with a string and an int.
        obj.DisplayInfo();  // Display information from both constructors.
    }
   
    
}

class MyClass
{
    private string _message;
    private int _number;

    // First constructor
    public MyClass(string message)
    {
        _message = message;
        Console.WriteLine("Constructor 1: " + message);
    }

    // Second constructor (chains to the first constructor using this())
    public MyClass(string message, int number) : this(message)
    {
        _number = number;
        Console.WriteLine("Constructor 2: " + number);
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Message: " + _message);
        Console.WriteLine("Number: " + _number);
    }
    
    
}
