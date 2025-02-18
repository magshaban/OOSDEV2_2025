### Lecture 4: Generics and Indexers

#### Overview
This lecture introduces generics and indexers in C#, which are powerful features that enhance code flexibility, reusability, and type safety. Generics allow you to write classes, methods, and collections that work with any data type, while indexers provide a way to access elements in a class using an index-like syntax.

#### Key Concepts
- **Generics**: Learn how to create generic classes, methods, and collections that can operate on any data type, providing type safety and reducing code duplication.
- **Generic Collections**: Understand how to use generic collections like `List<T>` and `Dictionary<TKey, TValue>` to store and manipulate data in a type-safe manner.
- **Generic Methods**: Explore how to define methods that can accept parameters of any type, allowing for flexible and reusable code.
- **Indexers**: Discover how to use indexers to access elements in a class as if it were an array, providing a more intuitive way to interact with collections or custom data structures.

#### Files
- `1_NonGenericArrayList.cs`: Demonstrates the use of a non-generic `ArrayList` to store different types of objects, highlighting the limitations of non-generic collections.
- `2_GenericList_Ex.cs`: Shows how to use a generic `List<T>` to store and manipulate a collection of strings, providing type safety and improved performance.
- `3_GenericDictionary.cs`: Illustrates the use of a generic `Dictionary<TKey, TValue>` to store key-value pairs, allowing for efficient data retrieval.
- `4_GenericMethod.cs`: Demonstrates how to create a generic method that can accept and print values of any type, showcasing the flexibility of generics.
- `5_GenericClass.cs`: Explains how to define a generic class (`Box<T>`) that can store and retrieve content of any type, promoting code reusability.
- `6_Indexer_ex1.cs`: Provides an example of how to implement an indexer in a custom class (`MyCollection`), allowing for array-like access to its elements.
- `7_Indexer_ex2.cs`: additional example for multi-dim indexers.