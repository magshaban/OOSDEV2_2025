//public returnType this[indexType index]
//{
//    get
//    {
//        // Return the value based on the index
//    }
//    set
//    {
//        // Set the value based on the index
//    }
//}

using System;

class MyCollection
{
    private string[] data = new string[10];

    // Indexer
    public string this[int index]
    {
        get
        {
            // Check for valid index
            if (index >= 0 && index < data.Length)
                return data[index];
            else
                throw new IndexOutOfRangeException("Index out of range");
        }
        set
        {
            // Check for valid index
            if (index >= 0 && index < data.Length)
                data[index] = value;
            else
                throw new IndexOutOfRangeException("Index out of range");
        }
    }
}

class Program
{
    static void Main()
    {
        MyCollection collection = new MyCollection();

        try
        {
            // Use the indexer to set values
            collection[0] = "First";
            collection[1] = "Second";

            // Use the indexer to get values
            Console.WriteLine(collection[0]); // Output: First
            Console.WriteLine(collection[1]); // Output: Second

            // Attempt to access an invalid index
            Console.WriteLine(collection[10]); // This will throw an exception
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}
