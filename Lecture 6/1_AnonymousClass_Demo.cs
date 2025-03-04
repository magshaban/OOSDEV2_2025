// demo of anonymous classes

using System;

namespace Anonymous
{
    class Test                     
    {
        public static void Main()
        {
            // anonymous classes can contain public fields only, subclass of Object
            var anonymousObject1 = new { Name="Gary", Age=32 };         // read only
            Console.WriteLine("Name: " + anonymousObject1.Name + " Age: " + anonymousObject1.Age);
            // used a lot with LINQ Select to project onto
        }
    }
}
