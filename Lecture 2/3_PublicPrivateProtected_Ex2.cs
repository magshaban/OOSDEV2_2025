using System;

public class MyClass
{
    // Public field (accessible anywhere)
    public int PublicField = 10;

    // Private field (accessible only within this class)
    private int _privateField = 20;

    // Protected field (accessible within this class and derived classes)
    protected int ProtectedField = 30;

    // Internal field (accessible within the same assembly)
    internal int InternalField = 40;

    // Protected internal field (accessible within the same assembly or derived classes)
    protected internal int ProtectedInternalField = 50;

    // Private protected field (accessible within the same assembly and derived classes)
    private protected int PrivateProtectedField = 60;

    // Public method (accessible anywhere)
    public void PublicMethod()
    {
        Console.WriteLine("PublicMethod called");
    }

    // Private method (accessible only within this class)
    private void PrivateMethod()
    {
        Console.WriteLine("PrivateMethod called");
    }

    // Protected method (accessible within this class and derived classes)
    protected void ProtectedMethod()
    {
        Console.WriteLine("ProtectedMethod called");
    }

    // Internal method (accessible within the same assembly)
    internal void InternalMethod()
    {
        Console.WriteLine("InternalMethod called");
    }

    // Protected internal method (accessible within the same assembly or derived classes)
    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("ProtectedInternalMethod called");
    }

    // Private protected method (accessible within the same assembly and derived classes)
    private protected void PrivateProtectedMethod()
    {
        Console.WriteLine("PrivateProtectedMethod called");
    }
}

// Derived class
public class DerivedClass : MyClass
{
    public void AccessBaseClassMembers()
    {
        // Accessing protected members from the base class
        Console.WriteLine(ProtectedField); // Allowed
        ProtectedMethod(); // Allowed

        // Accessing private protected members from the base class
        Console.WriteLine(PrivateProtectedField); // Allowed
        PrivateProtectedMethod(); // Allowed
    }
}

// Another class in the same assembly
public class AnotherClass
{
    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();

        // Accessing public members
        Console.WriteLine(myClass.PublicField); // Allowed
        myClass.PublicMethod(); // Allowed

        // Accessing internal members
        Console.WriteLine(myClass.InternalField); // Allowed
        myClass.InternalMethod(); // Allowed

        // Accessing protected internal members
        Console.WriteLine(myClass.ProtectedInternalField); // Allowed
        myClass.ProtectedInternalMethod(); // Allowed

        // Private and private protected members are not accessible here
        // Console.WriteLine(myClass._privateField); // Error
        // myClass.PrivateMethod(); // Error
        // Console.WriteLine(myClass.PrivateProtectedField); // Error
        // myClass.PrivateProtectedMethod(); // Error
    }
}
