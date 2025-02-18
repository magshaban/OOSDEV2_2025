
//class ClassName<T>
//{
//    // Fields, properties, methods, etc. that use T
//}

using System;

class Box<T>
{
    private T content;

    public Box(T value)
    {
        content = value;
    }

    public T GetContent()
    {
        return content;
    }
}

class Program
{
    static void Main()
    {
        Box<int> intBox = new Box<int>(123);
        Console.WriteLine(intBox.GetContent()); // Output: 123

        Box<string> stringBox = new Box<string>("Hello");
        Console.WriteLine(stringBox.GetContent()); // Output: Hello
    }
}