using System;
using System.Reflection.Metadata.Ecma335;

delegate string GreetingDelgate();

class Person
{
    public string Name { get; set; }

    public string SayHello()
    {
        return "Hello " + Name;
    }

    public string SayGoodBye()
    {
        return "GoodBye " + Name;
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Person p1 = new Person { Name = "John" };

        GreetingDelgate gd1 = null;
        gd1 += p1.SayHello;
        System.Console.WriteLine(gd1());
        gd1 += p1.SayGoodBye;
        System.Console.WriteLine(gd1());

        GreetingDelgate gd2 = new GreetingDelgate(() => { return "See you soon" + p1.Name; });
        System.Console.WriteLine(gd2());
    }
}
