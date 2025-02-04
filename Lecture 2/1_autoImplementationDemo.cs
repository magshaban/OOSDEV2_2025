Auto Implementaion   
//You don’t need to manually define a private backing field (e.g., private string _name;).
//The compiler automatically generates the backing field for you.

public class Person
{
    // Backing field for the Name property
    private string _name;

    // Traditional property with get and set
    public string Name
    {
        get { return _name; }       // Get the value of the backing field
        set { _name = value; }      // Set the value of the backing field
    }
}

//This can be replaced by: 

/*public class Person
*{
*    // Auto-implemented property
*    public string Name { get; set; } // No need to define a backing field
*/}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        // Set the Name property
        person.Name = "John";

        // Get the Name property
        Console.WriteLine($"Name: {person.Name}");
    }
}
