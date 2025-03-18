using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting tasks...");

        // Start three tasks concurrently
        Task task1 = DoWorkAsync("Task 1", 7000); // Simulate 7 seconds of work
        Task task2 = DoWorkAsync("Task 2", 3000); // Simulate 3 seconds of work
        Task task3 = DoWorkAsync("Task 3", 1000); // Simulate 1 second of work

        // Wait for all tasks to complete
        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("All tasks completed!");
    }

    static async Task DoWorkAsync(string taskName, int delay)
    {
        Console.WriteLine($"{taskName} started.");

        // Simulate work by delaying for the specified time
        await Task.Delay(delay);

        Console.WriteLine($"{taskName} completed after {delay} ms.");
    }
}
