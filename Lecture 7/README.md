### Lecture 7: Revision and Memory Management

#### Overview
This lecture revisits key concepts of object-oriented software development and advanced C# features. It covers managed vs. unmanaged code, memory management with heaps and stacks, garbage collection, and parameter passing mechanisms in C#. Additionally, practical demonstrations include delegates, operator overloading, and lambda expressions.

#### Key Concepts
- **Managed vs. Unmanaged Code**: Understanding how C# is a managed language, which allows for memory safety and cross-platform execution.
- **Heaps and Stacks**: Differentiating between the stack (which stores function calls and local variables) and the heap (which stores objects and reference data).
- **Garbage Collection**: Learning how memory is automatically managed using generations and a large object heap.
- **Pass by Value vs. Pass by Reference**: Exploring how C# handles value and reference types when passing parameters in methods.
- **Advanced C# Features**:
  - **Delegates**: Mechanisms to reference and invoke methods dynamically.
  - **Operator Overloading**: Customizing how operators behave for user-defined types.
  - **Lambda Expressions**: Defining concise, inline functions without explicitly naming them.

#### Files
- `1_Delegate_Demo.cs`: Demonstrates delegate usage, allowing methods to be assigned dynamically and executed through delegate instances.
- `2_OperatorOverloading_Demo.cs`: Shows how to overload operators in a struct (`Time`), enabling custom addition and subtraction operations.
- `3_Lambda_Demo.cs`: Explores lambda expressions as a way to create inline functions, improving code clarity and reducing verbosity.