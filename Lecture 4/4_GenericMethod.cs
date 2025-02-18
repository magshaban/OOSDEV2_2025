//returnType MethodName<T>(T parameter)
//{
    // Method body
//}


using System;

class Utilities
{
    public void Print<T>(T value)
    {
        Console.WriteLine(value);
    }
}

class Program
{
    static void Main()
    {
        Utilities utils = new Utilities();
        utils.Print(42);           // Output: 42
        utils.Print("Hello");      // Output: Hello
        utils.Print(3.14);         // Output: 3.14
    }
}