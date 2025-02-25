### Lecture 5: Enums, Structs, Exceptions, Enumerators, and Operator Overloading

#### Overview
In this lecture, we explore advanced object-oriented programming (OOP) features in C#, such as enums, structs, exception handling, enumerators, and operator overloading. These features are essential for creating sophisticated and maintainable software. Enums and structs offer structured data types that improve code readability and performance. Exception handling is vital for robust error management, preventing crashes and enhancing user experience. Enumerators enable efficient collection traversal, and operator overloading allows for more intuitive and readable interactions with custom types. By mastering these concepts, you will enhance your ability to write efficient, reliable, and maintainable code.

#### Key Concepts
- **Enums**: Enumerations (enums) allow you to define a set of named integral constants that can make your code more readable and maintainable. Enums are particularly useful for representing a collection of related values, such as days of the week or states in a state machine. Learn how to define enums, convert between enum values and their underlying types, and use enums in switch statements and other control structures.

- **Structs**: Structs are value types that are typically used to encapsulate small groups of related variables, such as coordinates or complex numbers. Unlike classes, structs are allocated on the stack, which can lead to performance benefits in certain scenarios. Understand the differences between structs and classes, how to define and use structs, and the implications of value-type semantics, including copying behavior and memory allocation.

- **Exception Handling**: Exception handling is a critical aspect of robust software development. Learn how to use try/catch/finally blocks to manage runtime errors gracefully, ensuring that your application can handle unexpected conditions without crashing. Explore different types of exceptions, how to throw and catch exceptions, and best practices for creating custom exception classes.

- **Enumerators and Iterators**: Enumerators and iterators provide a way to traverse collections in a controlled manner. Discover how to implement custom enumerators using the `IEnumerator` interface and the `yield return` statement, enabling you to create classes that can be iterated over using `foreach` loops. Learn about the benefits of using iterators for lazy evaluation and deferred execution.

- **Operator Overloading**: Operator overloading allows you to define custom behavior for standard operators (such as +, -, *, and /) in your user-defined types. This can make your classes and structs more intuitive to use and can simplify complex operations. Explore how to overload operators in C#, the rules and limitations of operator overloading, and practical examples of using operator overloading to enhance the usability of your types.

#### Files
- `1_EnumDemo.cs`: Demonstrates the use of an enum (`DaysOfWeek`) and conversions between enum values and integers.
- `1_EnumDemo2.cs`: Provides additional examples of enums, including parsing string values into enums and demonstrating value-type behavior.

- `2_StructDemo.cs`: Introduces structs by defining a `Point` structure with fields, a constructor, and methods.
- `2_StructDemo2.cs`: Explores structs further with a `ClockTime` struct, demonstrating constructors, properties, and the impact of value-type copying.

- `3_ExceptionDemo.cs`: Shows how to handle a `DivideByZeroException` with a try/catch block and ensures execution of the `finally` block.
- `3_ExceptionDemo2.cs`: Demonstrates an unhandled `IndexOutOfRangeException` to highlight the importance of exception handling.
- `3_ExceptionDemo3.cs`: Illustrates handling a `FormatException` with a try/catch block to prevent program crashes.
- `3_ExceptionDemo4.cs`: Explains multiple catch blocks, ensuring proper exception handling for various error scenarios.

- `4_EnumeratorDemo.cs`: Implements a custom enumerable class (`WeekEnumerator`) that allows iteration over a week's days using `yield return`.
- `4_EnumeratorDemo2.cs`: Provides a more advanced enumeration example using the `Family` class, showcasing multiple iterators.

- `5_OperatorOverloading.cs`: Demonstrates operator overloading in a `Money` struct, enabling intuitive arithmetic and comparison operations.
