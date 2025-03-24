// Selection Sort Algorithm
// =======================
// This program demonstrates the selection sort algorithm.
// Selection sort works by repeatedly finding the minimum element from the unsorted part
// and putting it at the beginning. Time complexity is O(n²) in all cases.

using System;

class SelectionSortDemo
{
    /// <summary>
    /// Sorts an integer array in ascending order using selection sort
    /// </summary>
    /// <param name="data">Array to be sorted</param>
    static void SelectionSort(int[] data)
    {
        int n = data.Length;
        int comparisons = 0;  // Track total comparisons
        int swaps = 0;        // Track total swaps

        Console.WriteLine("\nStarting Selection Sort...");
        Console.WriteLine("Initial array: [" + string.Join(", ", data) + "]");

        // Outer loop: move the boundary of the unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine($"\nPass {i + 1}:");
            
            // Assume the first element is the smallest
            int minIndex = i;
            int minValue = data[i];

            Console.WriteLine($"  Current minimum: {minValue} at position {minIndex}");
            Console.WriteLine($"  Searching unsorted portion from position {i + 1} to {n - 1}");

            // Inner loop: find the minimum in the unsorted array
            for (int j = i + 1; j < n; j++)
            {
                comparisons++;
                Console.WriteLine($"    Comparing {data[j]} with current minimum {minValue}");

                if (data[j] < minValue)
                {
                    minValue = data[j];
                    minIndex = j;
                    Console.WriteLine($"      New minimum found: {minValue} at position {minIndex}");
                }
            }

            // Swap the found minimum element with the first element
            if (minIndex != i)
            {
                Console.WriteLine($"  Swapping {data[i]} (position {i}) with {minValue} (position {minIndex})");
                Swap(ref data[i], ref data[minIndex]);
                swaps++;
            }
            else
            {
                Console.WriteLine("  No swap needed - element already in correct position");
            }

            // Display array state after this pass
            Console.WriteLine($"After pass {i + 1}: [" + string.Join(", ", data) + "]");
            Console.WriteLine($"Total comparisons: {comparisons}, Total swaps: {swaps}");
        }

        Console.WriteLine("\nSorting complete!");
        Console.WriteLine($"Final sorted array: [" + string.Join(", ", data) + "]");
        Console.WriteLine($"Total comparisons made: {comparisons}");
        Console.WriteLine($"Total swaps made: {swaps}");
    }

    /// <summary>
    /// Helper method to swap two elements in an array
    /// </summary>
    /// <param name="a">First element reference</param>
    /// <param name="b">Second element reference</param>
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    /// <summary>
    /// Main method to demonstrate selection sort
    /// </summary>
    public static void Main()
    {
        // Test data with duplicate values to demonstrate all cases
        int[] data = { 4, 9, 3, 8, 6, 3, 7, 5 };

        Console.WriteLine("Selection Sort Demonstration");
        Console.WriteLine("===========================");
        Console.WriteLine("Original array: [" + string.Join(", ", data) + "]");

        // Perform the sort
        SelectionSort(data);

        Console.WriteLine("\nNote: Selection sort has O(n²) time complexity in all cases.");
        Console.WriteLine("It performs O(n) swaps, making it useful when memory writes are expensive.");
    }
}