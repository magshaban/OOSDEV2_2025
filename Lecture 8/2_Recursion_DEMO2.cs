using System;

namespace FactorialDemo
{
    public class FactorialCalculator
    {
        // Recursive function to calculate factorial of n
        public int Factorial(int n)
        {
            // Base case: factorial of 0 or 1 is 1
            if (n == 0 || n == 1)
            {
                return 1;
            }

            // Recursive step: n! = n * (n-1)!
            return n * Factorial(n - 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the FactorialCalculator class
            FactorialCalculator calculator = new FactorialCalculator();

            // Demo: Calculate factorial of 5
            int result = calculator.Factorial(5);
            Console.WriteLine("5! = " + result);

            // Demo: Calculate factorial of 7
            result = calculator.Factorial(7);
            Console.WriteLine("7! = " + result);

            // Demo: Calculate factorial of 0
            result = calculator.Factorial(0);
            Console.WriteLine("0! = " + result);

            // Demo: Calculate factorial of 1
            result = calculator.Factorial(1);
            Console.WriteLine("1! = " + result);

            // Demo: Calculate factorial of a negative number (invalid input)
            try
            {
                result = calculator.Factorial(-3);
                Console.WriteLine("-3! = " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}