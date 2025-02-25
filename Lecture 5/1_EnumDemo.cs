
using System;

enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        DaysOfWeek today = DaysOfWeek.Wednesday;
        Console.WriteLine($"Today is: {today}");

        // Enum to int conversion
        int dayValue = (int)DaysOfWeek.Friday;
        Console.WriteLine($"Friday's value: {dayValue}");
    }
}
