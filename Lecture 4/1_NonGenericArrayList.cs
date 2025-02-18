using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add(10);       // Add an integer
        list.Add("Hello"); // Add a string
        list.Add(3.14);     // Add a double

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}