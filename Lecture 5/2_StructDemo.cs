using System;

struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(10, 20);
        p1.Display();

        // Structs are value types, so copying creates a new instance
        Point p2 = p1;
        p2.X = 30;
        p2.Display();
        p1.Display(); // p1 remains unchanged
    }
}