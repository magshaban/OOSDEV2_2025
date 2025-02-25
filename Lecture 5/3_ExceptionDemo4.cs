// Exceptions demo - part 3 - multiple catches, finally

using System;

class Exception3
{
    public static void Main()
    {
        int[] data = { 1, 2, 3, 4, 5 };

        // 1st catch block to match gets called, will match an object which is an instance of that
        // exception class or an object which is an instance of a subclass = > order essential
        // compiler will complain if order illogical

        try
        {
            Console.Write("Enter index: ");
            int i = Int32.Parse(Console.ReadLine());            // could throw FormatException
            Console.WriteLine(data[i]);                         // could throw IndexOutOfRangeException
        }
        catch (FormatException e1)
        {
            Console.WriteLine("Caught a FormatException Exception");
            Console.WriteLine(e1.Message);
        }
        catch (IndexOutOfRangeException e2)
        {
            Console.WriteLine("Caught a IndexOutOfRangeException Exception");
            Console.WriteLine(e2.Message);
        }
        catch (Exception)                                       // catch all, no named object here
        {
            Console.WriteLine("Caught a general Exception");
        }
        finally                                                 // always runs whether exception caught or not
        {
            Console.WriteLine("In finally block");         
        }

        Console.WriteLine("After try/catch");
    }
}