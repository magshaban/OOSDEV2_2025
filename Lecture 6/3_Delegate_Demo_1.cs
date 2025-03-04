using System;

// Define a delegate
delegate void PrintMessage(string message);

class Program
{
    // Method that matches the delegate signature
    static void DisplayMessage(string msg)
    {
        Console.WriteLine("Message: " + msg);
    }

    static void Main()
    {
        // Create an instance of the delegate and point it to the method
        PrintMessage printDel = new PrintMessage(DisplayMessage);

        // Invoke the delegate
        printDel("Hello, World!");
    }
}