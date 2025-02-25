// Exceptions demo - part 1 - unhandled exception

using System;

class Exception1
{    
    // if a method results in a exception being thrown which is not handled the
    // program will exit
    public static void Main()
    {
        int[] data = {1, 2, 3, 4, 5};

        int i = -1;
        
        // generate a exception
        Console.WriteLine(data[i]);                  // System.IndexOutOfRangeException
    }
}