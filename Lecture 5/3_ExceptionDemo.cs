using System;

class DivideByZeroExample
{
    static void Main()
    {
        int numerator = 10;
        int denominator = 0;
        int result;

        try
        {
            // Attempt to divide by zero
            result = numerator / denominator;
            Console.WriteLine("The result is: " + result);
        }
        catch (DivideByZeroException e)
        {
            // Handle the exception
            Console.WriteLine("An error occurred: " + e.Message);
            Console.WriteLine("Cannot divide by zero!");
        }
        finally
        {
            // This block will always execute
            Console.WriteLine("This is the finally block. It always runs, regardless of whether an exception occurred.");
        }
    }
}