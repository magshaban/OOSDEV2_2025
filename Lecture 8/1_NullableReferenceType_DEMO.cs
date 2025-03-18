 //Nullable refernce type
 
using System;

#nullable enable // Enable nullable reference types for this file

namespace NullableReferenceTypesExample
{
    class Student
    {
        // Properties
        public int ID { get; set; } // Non-nullable value type
        public string Name { get; set; } // Non-nullable reference type (due to #nullable enable)

        // Constructor
        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }

        // Method to display student information
        public void Info()
        {
            Console.WriteLine($"Student ID = {ID}, Name = {Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Student object
            Student s1 = new Student(111, "John");
            s1.Info(); // Output: Student ID = 111, Name = John

            // After many lines of code...
            s1 = null; // Assign null to s1 (this will cause a compiler warning because Name is non-nullable)

            // Uncommenting the following line will cause a runtime NullReferenceException
            // s1.Info(); // Warning: Dereference of a possibly null reference

            // Also works the same when you try to print null strings
            string name = null; // Assign null to a string (this will cause a compiler warning)

            // Uncommenting the following line will cause a runtime NullReferenceException
            // Console.WriteLine(name.Length); // Warning: Dereference of a possibly null reference

            // If you need to allow null, use the null-forgiving operator (!)
            s1 = null;
            s1!.Info(); // Suppress the compiler warning, but this will throw a NullReferenceException at runtime
        }
    }
}

//The #nullable enable directive and the <Nullable>enable</Nullable> project setting both serve the same purpose: enabling nullable reference types in C#. However, they are used in different contexts and have different scopes.