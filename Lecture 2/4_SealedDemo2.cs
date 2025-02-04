
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    // Override the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Bulldog : Dog
{
    // Seal the MakeSound method so no further overrides are allowed
    public sealed override void MakeSound()
    {
        Console.WriteLine("Bulldog barks loudly");
    }
}

// This will cause a compile-time error because MakeSound is sealed in Bulldog
// public class Puppy : Bulldog
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Puppy barks softly");
//     }
// }
