// Bubble Sort
// ==========
// This file implements the bubble sort algorithm in C#.
// Bubble sort repeatedly steps through the list, compares adjacent elements
// and swaps them if they are in the wrong order. The pass through the list
// is repeated until the list is sorted. Time complexity is O(n²).

using System;

class Utility
{
    /// <summary>
    /// Sorts an integer array in ascending order using bubble sort algorithm
    /// </summary>
    /// <param name="data">Array to be sorted</param>
    static void BubbleSort(int[] data)
    {
        int n = data.Length;
        int comparisons = 0;                  // Track total comparisons made
        int swaps = 0;                        // Track total swaps performed
        bool sorted = false;                  // Early exit flag

        Console.WriteLine("\nStarting Bubble Sort...");
        Console.WriteLine("Initial array: [" + string.Join(", ", data) + "]");

        // Outer loop: makes n-1 passes through the array
        for (int i = 0; (i < n - 1) && (!sorted); i++)
        {
            Console.WriteLine($"\nPass {i + 1}:");
            sorted = true;  // Assume array is sorted until we find otherwise

            // Inner loop: bubble up the smallest remaining element
            // Starts from end and moves toward the front
            for (int j = n - 1; j > i; j--)
            {
                comparisons++;
                Console.WriteLine($"  Comparing elements at positions {j-1}[{data[j-1]}] and {j}[{data[j]}]");

                if (data[j] < data[j - 1])
                {
                    // Elements are out of order - swap them
                    Swap(ref data[j], ref data[j - 1]);
                    swaps++;
                    sorted = false;  // We had to swap, so array wasn't sorted
                    Console.WriteLine($"    Swapped: [{data[j-1]} <-> {data[j]}]");
                }
            }

            // Display array state after this pass
            Console.WriteLine($"After pass {i + 1}: [" + string.Join(", ", data) + "]");
            Console.WriteLine($"Comparisons so far: {comparisons}, Swaps so far: {swaps}");

            // Early exit if no swaps were made in this pass
            if (sorted)
            {
                Console.WriteLine("Early exit: No swaps in this pass - array is sorted");
            }
        }

        Console.WriteLine("\nSorting complete!");
        Console.WriteLine($"Total comparisons: {comparisons}");
        Console.WriteLine($"Total swaps: {swaps}");
    }

    /// <summary>
    /// Swaps two integer values
    /// </summary>
    /// <param name="i">First integer reference</param>
    /// <param name="j">Second integer reference</param>
    static void Swap(ref int i, ref int j)
    {
        int temp = j;
        j = i;
        i = temp;
    }

    /// <summary>
    /// Main method to demonstrate bubble sort
    /// </summary>
    public static void Main()
    {
        // Test data with duplicate values to demonstrate all cases
        int[] data = { 4, 9, 3, 8, 6, 3, 7, 5 };

        Console.WriteLine("Bubble Sort Demonstration");
        Console.WriteLine("========================");
        Console.WriteLine("Original array: [" + string.Join(", ", data) + "]");

        // Perform the sort
        BubbleSort(data);

        // Display final sorted array
        Console.WriteLine("\nFinal sorted array: [" + string.Join(", ", data) + "]");
        Console.WriteLine("\nNote: Bubble sort has O(n²) time complexity in worst and average cases.");
    }
}