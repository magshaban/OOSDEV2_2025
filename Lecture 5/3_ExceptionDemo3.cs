// Exceptions demo - part 2 - handled exception

using System;

class Exception2
{
    public static void Main()
    {
        // try/catch lets us handle the exception gracefully and continue execution

        try                                              // try something which might cause an exception
        {
            int x = Int32.Parse("abc");                  // throws FormatException or OverflowException
        }
        catch (FormatException e)                         // catch this type of exception
        {
            Console.WriteLine("Caught a FormatException Exception");
            Console.WriteLine(e.Message);                // display description of error that caused the exception
        }
       
        Console.WriteLine("After try/catch");
    }
}