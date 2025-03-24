namespace BinSearch
{
    public class Search
    {
        /// <summary>
        /// Performs binary search on a sorted integer array
        /// </summary>
        /// <param name="data">Sorted array to search (must be ascending order)</param>
        /// <param name="target">Value to find in the array</param>
        /// <returns>Index of target if found, -1 if not found</returns>
        public static int BinarySearch(int[] data, int target)
        {
            Console.WriteLine("Starting binary search...");
            
            // Initialize search boundaries
            int bottom = 0;                  // Start of current search range
            int top = data.Length - 1;       // End of current search range
            int steps = 0;                   // Counter for algorithm steps

            // Continue searching while there are elements to check
            while (bottom <= top)
            {
                steps++;
                
                // Calculate middle index - this is where we'll check next
                // Using (bottom + top)/2 can cause overflow for very large arrays,
                // but is fine for our demonstration purposes
                int middle = (bottom + top) / 2;
                
                // Visual representation of current search range
                Console.WriteLine($"\nStep {steps}:");
                Console.WriteLine($"- Search range: indices {bottom} to {top}");
                
                // Display the current subarray being considered
                Console.Write("- Array segment: [");
                for (int i = bottom; i <= top; i++)
                {
                    if (i == middle) 
                        Console.Write($"({data[i]}) "); // Highlight middle element
                    else 
                        Console.Write(data[i] + " ");
                }
                Console.WriteLine("]");
                
                Console.WriteLine($"- Checking middle element at index {middle}: {data[middle]}");
                
                // Three possible cases when we examine the middle element:
                if (data[middle] == target)
                {
                    // Case 1: Found our target!
                    Console.WriteLine($"\nFound target {target} at index {middle}!");
                    Console.WriteLine($"Total steps taken: {steps}");
                    return middle;
                }
                else if (data[middle] > target)
                {
                    // Case 2: Middle element is greater than target
                    // Therefore, target must be in the left half (if present)
                    Console.WriteLine($"{data[middle]} > {target} - searching LEFT half");
                    top = middle - 1; // Adjust top boundary
                }
                else
                {
                    // Case 3: Middle element is less than target
                    // Therefore, target must be in the right half (if present)
                    Console.WriteLine($"{data[middle]} < {target} - searching RIGHT half");
                    bottom = middle + 1; // Adjust bottom boundary
                }
            }
            
            // If we exit the loop, the target wasn't found
            Console.WriteLine($"\nTarget {target} not found in array.");
            Console.WriteLine($"Total steps taken: {steps}");
            return -1;
        }
    }
}