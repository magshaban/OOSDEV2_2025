/*
 * LinkedListDemo.cs
 * 
 * A comprehensive, educational implementation of a singly linked list in C#.
 * This file demonstrates:
 * - Node structure
 * - Linked list operations (AddFirst, AddLast, Remove, Traverse)
 * - IEnumerable implementation for foreach support
 * - Detailed comments explaining each concept
 * - Example usage with test cases
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListEducation
{
    /// <summary>
    /// Represents a node in the linked list
    /// </summary>
    /// <typeparam name="T">The type of data stored in the node</typeparam>
    public class Node<T>
    {
        /// <summary>
        /// The data element stored in this node
        /// </summary>
        public T Element { get; set; }

        /// <summary>
        /// Reference to the next node in the chain
        /// </summary>
        public Node<T> Next { get; set; }

        /// <summary>
        /// Constructs a new node with the given element
        /// </summary>
        /// <param name="element">The data to store in this node</param>
        public Node(T element)
        {
            this.Element = element;
            this.Next = null; // New nodes always end the chain initially
        }
    }

    /// <summary>
    /// Implementation of a singly linked list with basic operations
    /// </summary>
    /// <typeparam name="T">The type of elements in the list</typeparam>
    public class LinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// The first node in the linked list (entry point)
        /// </summary>
        private Node<T> Head { get; set; }

        /// <summary>
        /// Creates an empty linked list
        /// </summary>
        public LinkedList()
        {
            Head = null; // Empty list has no nodes
        }

        /// <summary>
        /// Adds a new element at the beginning of the list
        /// </summary>
        /// <param name="element">The element to add</param>
        public void AddFirst(T element)
        {
            Console.WriteLine($"Adding {element} at the beginning of the list");

            if (Head == null)
            {
                // List is empty - create the first node
                Head = new Node<T>(element);
            }
            else
            {
                // List has elements - insert new node before current head
                Node<T> oldHead = Head;
                Head = new Node<T>(element);
                Head.Next = oldHead; // Link new head to old head
            }
        }

        /// <summary>
        /// Adds a new element at the end of the list
        /// </summary>
        /// <param name="element">The element to add</param>
        public void AddLast(T element)
        {
            Console.WriteLine($"Adding {element} at the end of the list");

            if (Head == null)
            {
                // List is empty - same as AddFirst
                Head = new Node<T>(element);
            }
            else
            {
                // Traverse to find the last node
                Node<T> current = Head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                // Add new node after the last node
                current.Next = new Node<T>(element);
            }
        }

        /// <summary>
        /// Removes the first occurrence of an element from the list
        /// </summary>
        /// <param name="element">The element to remove</param>
        /// <returns>True if element was found and removed, false otherwise</returns>
        public bool Remove(T element)
        {
            Console.WriteLine($"Attempting to remove {element} from the list");

            if (Head == null)
            {
                Console.WriteLine("List is empty - nothing to remove");
                return false;
            }

            // Special case: removing the head node
            if (Head.Element.Equals(element))
            {
                Head = Head.Next;
                Console.WriteLine($"Removed head element {element}");
                return true;
            }

            Node<T> current = Head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Element.Equals(element))
                {
                    // Found the node to remove - bypass it in the chain
                    previous.Next = current.Next;
                    Console.WriteLine($"Removed element {element}");
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            Console.WriteLine($"Element {element} not found in list");
            return false;
        }

        /// <summary>
        /// Prints all elements in the list (for demonstration purposes)
        /// </summary>
        public void Traverse()
        {
            Console.WriteLine("\nCurrent List Contents:");
            Console.WriteLine("----------------------");

            Node<T> current = Head;
            int position = 0;

            while (current != null)
            {
                Console.WriteLine($"Position {position}: {current.Element}");
                current = current.Next;
                position++;
            }

            Console.WriteLine("----------------------\n");
        }

        /// <summary>
        /// Enables foreach iteration over the linked list
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;

            while (current != null)
            {
                yield return current.Element;
                current = current.Next;
            }
        }

        // Required for non-generic IEnumerable interface
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    /// <summary>
    /// Demonstration program showing linked list operations
    /// </summary>
    public class LinkedListDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Linked List Educational Demonstration ===");
            Console.WriteLine("Creating a new linked list of integers...\n");

            // Create and populate the linked list
            LinkedList<int> list = new LinkedList<int>();

            // Demonstrate AddFirst
            Console.WriteLine("\n=== Adding Elements to Front ===");
            list.AddFirst(1);
            list.AddFirst(5);
            list.AddFirst(110);
            list.Traverse();

            // Demonstrate AddLast
            Console.WriteLine("\n=== Adding Elements to End ===");
            list.AddLast(11);
            list.AddLast(75);
            list.Traverse();

            // Demonstrate Remove
            Console.WriteLine("\n=== Removing Elements ===");
            list.Remove(5);
            list.Remove(99); // Non-existent element
            list.Traverse();

            // Demonstrate foreach support
            Console.WriteLine("\n=== Iterating with foreach ===");
            foreach (int value in list)
            {
                Console.WriteLine($"Foreach value: {value}");
            }

            // Additional edge cases
            Console.WriteLine("\n=== Edge Case Testing ===");
            Console.WriteLine("Testing empty list removal:");
            LinkedList<int> emptyList = new LinkedList<int>();
            emptyList.Remove(1);

            Console.WriteLine("\nTesting single element list:");
            LinkedList<int> singleItemList = new LinkedList<int>();
            singleItemList.AddFirst(42);
            singleItemList.Traverse();
            singleItemList.Remove(42);
            singleItemList.Traverse();

            Console.WriteLine("\n=== Demonstration Complete ===");
        }
    }
}