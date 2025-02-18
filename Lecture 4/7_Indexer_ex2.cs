
using System;

class Matrix
{
    private int[,] data = new int[3, 3];

    // Indexer with multiple parameters
    public int this[int row, int col]
    {
        get
        {
            // Check for valid indices
            if (row >= 0 && row < data.GetLength(0) && col >= 0 && col < data.GetLength(1))
                return data[row, col];
            else
                throw new IndexOutOfRangeException("Index out of range");
        }
        set
        {
            // Check for valid indices
            if (row >= 0 && row < data.GetLength(0) && col >= 0 && col < data.GetLength(1))
                data[row, col] = value;
            else
                throw new IndexOutOfRangeException("Index out of range");
        }
    }
}

class Program
{
    static void Main()
    {
        Matrix matrix = new Matrix();

        try
        {
            // Use the indexer to set values
            matrix[0, 0] = 1;
            matrix[1, 1] = 2;

            // Use the indexer to get values
            Console.WriteLine(matrix[0, 0]); // Output: 1
            Console.WriteLine(matrix[1, 1]); // Output: 2

            // Attempt to access an invalid index
            Console.WriteLine(matrix[3, 3]); // This will throw an exception
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