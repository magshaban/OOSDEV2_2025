// Binary Search
// =============
// This file implements the binary search algorithm in C#.
// Binary search efficiently locates a target value in a sorted array by repeatedly
// dividing the search interval in half. The time complexity is O(log n).

using System;

class Search
{
    /// <summary>
    /// Performs binary search on a sorted integer array
    /// </summary>
    /// <param name="data">Sorted array to search (must be in ascending order)</param>
    /// <param name="target">Value to find in the array</param>
    /// <param name="found">Output parameter for found position (or -1 if not found)</param>
    /// <param name="comparisons">Output parameter counting the number of comparisons made</param>
    public static void BinarySearch(int[] data, int target, out int found, out int comparisons)
    {
        // Initialize search boundaries
        int bottom = 0;                     // Start index of current search range
        int top = data.Length - 1;          // End index of current search range
        int middle;                          // Midpoint of current search range
        
        found = -1;                          // Default return if target not found
        comparisons = 0;                     // Initialize comparison counter

        // Continue searching while there are elements to examine
        while (bottom <= top)
        {
            // Calculate midpoint using integer division (automatically truncates)
            middle = (bottom + top) / 2;

            comparisons++; // Count each comparison operation
            
            // Three possible cases when examining the middle element:
            if (data[middle] == target)
            {
                // Case 1: Exact match found
                found = middle;
                return;
            }
            else if (data[middle] > target)
            {
                // Case 2: Middle element is greater than target
                // Search the left half by moving the top boundary
                top = middle - 1;
            }
            else
            {
                // Case 3: Middle element is less than target
                // Search the right half by moving the bottom boundary
                bottom = middle + 1;
            }
        }
    }

    /// <summary>
    /// Test harness for binary search implementation
    /// </summary>
    public static void Main()
    {
        // Sorted test data (binary search requires sorted input)
        int[] data = {1, 3, 4, 5, 6, 7, 9, 12, 14};
        
        Console.WriteLine("Binary Search Demonstration");
        Console.WriteLine("==========================");
        Console.WriteLine("Test Data: [" + string.Join(", ", data) + "]\n");

        // Test case 1: Value in middle of array
        int found, comparisons;
        Search.BinarySearch(data, 9, out found, out comparisons);
        Console.WriteLine("Search for 9: Found at index {0} (took {1} comparisons)", 
                        found, comparisons);

        // Test case 2: Value in first half of array
        Search.BinarySearch(data, 7, out found, out comparisons);
        Console.WriteLine("Search for 7: Found at index {0} (took {1} comparisons)", 
                        found, comparisons);

        // Test case 3: Value at end of array
        Search.BinarySearch(data, 14, out found, out comparisons);
        Console.WriteLine("Search for 14: Found at index {0} (took {1} comparisons)", 
                        found, comparisons);

        // Test case 4: Value not in array
        Search.BinarySearch(data, 13, out found, out comparisons);
        Console.WriteLine("Search for 13: Not found (took {0} comparisons)", 
                        comparisons);

        Console.WriteLine("\nNote: All searches operate in O(log n) time");
    }
}