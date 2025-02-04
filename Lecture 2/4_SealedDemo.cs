public sealed class Vehicle
{
    public string Name { get; set; }

    public Vehicle(string name)
    {
        Name = name;
    }

    public void Start()
    {
        Console.WriteLine($"{Name} is starting...");
    }
}

// This will cause a compile-time error because Vehicle is sealed
// public class Car : Vehicle
// {
//     public Car(string name) : base(name) { }
// }

