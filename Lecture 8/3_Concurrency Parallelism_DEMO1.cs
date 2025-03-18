using System;
using System.Threading;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multithreading allows us to run multiple tasks concurrently.
            // In this example, we'll create two threads: one for counting down and one for counting up.

            // Get the current thread (which is the main thread).
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread"; // Give the main thread a name for identification.

            // Create the first thread to run the CountDown method.
            // The lambda expression `() => CountDown("Timer #1")` is used to pass the method to the thread.
            Thread thread1 = new Thread(() => CountDown("Timer #1"));

            // Create the second thread to run the CountUp method.
            Thread thread2 = new Thread(() => CountUp("Timer #2"));

            // Start both threads. They will run concurrently.
            thread1.Start();
            thread2.Start();

            // The main thread continues executing while the other threads are running.
            Console.WriteLine(mainThread.Name + " is complete!");

            // Wait for user input to keep the console window open.
            Console.ReadKey();
        }

        // This method counts down from 10 to 0.
        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                // Print the current countdown value.
                Console.WriteLine("Timer #1 : " + i + " seconds");

                // Pause the thread for 1 second (1000 milliseconds) to simulate a countdown.
                Thread.Sleep(1000);
            }

            // Notify when the countdown is complete.
            Console.WriteLine("Timer #1 is complete!");
        }

        // This method counts up from 0 to 10.
        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                // Print the current count-up value.
                Console.WriteLine("Timer #2 : " + i + " seconds");

                // Pause the thread for 1 second (1000 milliseconds) to simulate a count-up.
                Thread.Sleep(1000);
            }

            // Notify when the count-up is complete.
            Console.WriteLine("Timer #2 is complete!");
        }
    }
}
