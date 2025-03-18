
using System;

namespace RecursionDemo
{
    public class PowerCalculator
    {
        // Recursive function to calculate x^n
        public double Pow(double x, int n)
        {
            // Base case: if n is negative, return 0 (as per the example)
            if (n < 0)
            {
                Console.WriteLine("Negative exponent is not supported in this example.");
                return 0;
            }

            // Base case: x^0 = 1
            if (n == 0)
            {
                return 1;
            }

            // Base case: x^1 = x
            if (n == 1)
            {
                return x;
            }

            // Recursive step: x^n = x * x^(n-1)
            return x * Pow(x, n - 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the PowerCalculator class
            PowerCalculator calculator = new PowerCalculator();

            // Demo: Calculate 2^4 using recursion
            double result = calculator.Pow(2, 4);
            Console.WriteLine("2^4 = " + result);

            // Demo: Calculate 3^5 using recursion
            result = calculator.Pow(3, 5);
            Console.WriteLine("3^5 = " + result);

            // Demo: Calculate 5^0 using recursion
            result = calculator.Pow(5, 0);
            Console.WriteLine("5^0 = " + result);

            // Demo: Calculate 2^-3 using recursion (should return 0 as per the example)
            result = calculator.Pow(2, -3);
            Console.WriteLine("2^-3 = " + result);
        }
    }
}