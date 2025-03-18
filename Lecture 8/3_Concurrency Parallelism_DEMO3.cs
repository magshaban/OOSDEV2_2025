using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting count-up and count-down tasks...");

        // Start the count-up task
        Task countUpTask = CountUpAsync();

        // Start the count-down task
        Task countDownTask = CountDownAsync();

        // Wait for both tasks to complete
        await Task.WhenAll(countUpTask, countDownTask);

        Console.WriteLine("Both tasks completed!");
    }

    static async Task CountUpAsync()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"Count-Up: {i}");
            await Task.Delay(500); // Simulate work by delaying for 500ms
        }
        Console.WriteLine("Count-Up task completed!");
    }

    static async Task CountDownAsync()
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"Count-Down: {i}");
            await Task.Delay(500); // Simulate work by delaying for 500ms
        }
        Console.WriteLine("Count-Down task completed!");
    }
}