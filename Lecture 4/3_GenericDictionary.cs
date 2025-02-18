
//Dictionary<TKey, TValue>

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> employees = new Dictionary<int, string>();
        employees.Add(1, "Alice");
        employees.Add(2, "Bob");
        employees.Add(3, "Charlie");

        Console.WriteLine(employees[2]); // Output: Bob
    }
}