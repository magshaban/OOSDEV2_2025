/*
 * Object-Oriented Programming (OOP) - Advanced Software Development 2
 * Getting Started with OPP in C# - Lecture 1
 *
 * Description:
 * This program provides an introductory overview of Object-Oriented Programming (OOP) in C#.
 * It covers essential concepts such as classes, objects, properties, constructors, methods, 
 * inheritance, and polymorphism, demonstrating their basic practical applications.
 * 
 * For the full project, refer to the directory (in github): Lec1_Code
 *
 * Lecturer: Dr. Maged Shaban
 * Department of Computing, TU-Dublin
 */


using System; // Importing the System namespace for core functionalities like Console operations.


// This program follows the traditional entry-point style in C# (pre-C# 9.0).
// In newer versions (C# 9.0 and later), a simplified top-level statement approach can be used,
// where the Main method is implicitly handled by the compiler, eliminating the need for an explicit definition.
// However, for training purposes and throughout this course, including tutorial submissions,
// you are expected to use the traditional entry-point style.

class  Program // Defining a class named `Program` (required in older C# versions).
{
    static void Main(string[] args) // Explicit entry point for the application.
    {
        // The `Main` method serves as the starting point of the program.
        // It is defined within the `Program` class, which was required in older C# versions.
        // In newer versions, we can write code directly in the file without defining `Main` explicitly.

        // The `args` parameter allows the program to accept command-line arguments.
        // Example usage: Running `dotnet run arg1 arg2` will pass `arg1` and `arg2` into `args[]`.


        // Creating instances of the Person class and initializing properties
        Person person1 = new Person();
        person1.Age = 18;
        person1.Name = "Alice";

        Person person2 = new Person();
        person2.Age = 20;
        person2.Name = "Bob";

        // Displaying information using string interpolation and concatenation
        // The commented line below uses string concatenation (less efficient):
        // Console.WriteLine("The first person name "+ person1.Name+ " , and his age is " + person1.Age);
        Console.WriteLine($"The first person name {person1.Name}, and their age is {person1.Age}");
        Console.WriteLine($"The second person name {person2.Name}, and their age is {person2.Age}");

        // Calling the Info() method to display person details
        person1.Info();
        person2.Info();

        // Calling a static method to display class-level information
        Person.ClassInfo();

        // Using a constructor to initialize a Person object with specific values
        Person person3 = new Person(name: "Alice", age: 3);
        person3.Info();

        // Creating and initializing a Student object (inherits from Person)
        Student student1 = new Student();
        student1.Name = "Keith";
        student1.Age = 23;
        student1.major = "Computer Science";

        // Displaying student-specific information
        System.Console.WriteLine($"This is the student's major: {student1.major}");

        // Calling class-level information method and Info() method
        Student.ClassInfo();
        student1.Info();

        // Creating and initializing a Teacher object (inherits from Person)
        Teacher teacher1 = new Teacher();
        teacher1.Name = "Maron";
        teacher1.Age = 34;
        teacher1.Subject = "Mathematics";

        // Displaying teacher-specific information
        System.Console.WriteLine($"This is the teacher's subject: {teacher1.Subject}");
        teacher1.Info();
    }
}

// Base class representing a general person
class Person
{
    // Properties:
    // The commented-out section below demonstrates how properties were traditionally implemented.
    // This approach uses private fields with explicit getter and setter methods.
    
    /*
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    */

    // The above implementation has been replaced with auto-implemented properties.
    // Auto-implemented properties simplify property definitions by eliminating the need for explicit fields.
    public int Age { get; set; }
    public string Name { get; set; }

    // Constructors to initialize Person objects
    public Person()
    {
        Name = "No name";
        Age = 0;
    }

    public Person(int age)
    {
        Name = "No name";
        Age = age;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Static method to provide information about the Person class
    public static void ClassInfo()
    {
        System.Console.WriteLine("This is the Person class.");
    }

    // Virtual method to display a Person's information
    // Marking it as 'virtual' allows derived classes to override this method
    public virtual void Info()
    {
        Console.WriteLine($"This is {Name}, {Age} years old.");
    }
}

// Derived class representing a Student (inherits from Person)
class Student : Person
{
    // Additional property specific to students
    public string major { get; set; }

    // Static method to provide information about the Student class
    public static void ClassInfo()
    {
        System.Console.WriteLine("This is the Student class.");
    }

    // Overriding the Info() method to maintain consistency with the base class
    public override void Info()
    {
        Console.WriteLine($"This is {Name}, {Age} years old.");
    }
}

// Derived class representing a Teacher (inherits from Person)
class Teacher : Person
{
    // Additional property specific to teachers
    public string Subject { get; set; }

    // Static method to provide information about the Teacher class
    public static void ClassInfo()
    {
        System.Console.WriteLine("This is the Teacher class.");
    }

    // Overriding the Info() method to maintain consistency with the base class
    public override void Info()
    {
        Console.WriteLine($"This is {Name}, {Age} years old.");
    }
}
