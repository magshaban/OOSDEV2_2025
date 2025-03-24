namespace BinSearch
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            // Binary search requires the input array to be sorted
            // This is our test dataset - notice it's in ascending order
            int[] testData = { 1, 3, 4, 5, 6, 7, 9, 12, 14 };
            
            // Display header and array contents for clarity
            Console.WriteLine("=== Binary Search Demonstration ===");
            Console.WriteLine("Array contents: [" + string.Join(", ", testData) + "]\n");
            
            // First test case - search for value 9 (exists in array)
            int target = 9;
            Console.WriteLine($"Searching for value: {target}");
            
            // Call our binary search implementation
            int findPos = Search.BinarySearch(testData, target);
            
            // Display results with clear success/failure messages
            if (findPos != -1)
            {
                Console.WriteLine($"\nSUCCESS: Found {target} at index position: {findPos}");
            }
            else
            {
                Console.WriteLine($"\nFAILURE: {target} not found in the array");
            }
            
            // Additional test cases to demonstrate different scenarios
            Console.WriteLine("\n=== Additional Test Cases ===");
            
            // Test case 1: Search for first element
            TestCase(testData, 1);   
            
            // Test case 2: Search for last element
            TestCase(testData, 14);  
            
            // Test case 3: Search for middle element
            TestCase(testData, 5);   
            
            // Test case 4: Search for non-existent element
            TestCase(testData, 8);   
        }
        
        /// <summary>
        /// Helper method to run and display a test case
        /// </summary>
        /// <param name="array">The sorted array to search</param>
        /// <param name="target">The value to find</param>
        private static void TestCase(int[] array, int target)
        {
            Console.WriteLine($"\nSearching for value: {target}");
            int pos = Search.BinarySearch(array, target);
            string result = pos != -1 ? $"Found at index {pos}" : "Not found";
            Console.WriteLine($"Result: {result}");
        }
    }
}