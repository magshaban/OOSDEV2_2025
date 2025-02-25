using System;
using System.Collections;

class WeekEnumerator : IEnumerable
{
    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < days.Length; i++)
        {
            yield return days[i];
        }
    }
}

class Program
{
    static void Main()
    {
        WeekEnumerator week = new WeekEnumerator();
        foreach (string day in week)
        {
            Console.WriteLine(day);
        }
    }
}