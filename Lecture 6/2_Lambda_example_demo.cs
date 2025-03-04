//(parameters) => expression-or-statement-block

Action greet = () => Console.WriteLine("Hello, World!");
greet(); // Output: Hello, World!


or 

Func<int, int, int> multiply = (x, y) => {
    int result = x * y;
    return result;
};
Console.WriteLine(multiply(6, 7)); // Output: 42