// Binary Search Tree Implementation
// ================================
// This file implements a generic binary search tree (BST) in C#.
// The BST maintains the invariant that for any given node:
// - All nodes in the left subtree have values less than or equal to the node's value
// - All nodes in the right subtree have values greater than the node's value
// The implementation uses generics and requires nodes to be IComparable.

using System;
using System.Collections.Generic;

namespace Trees
{
    /// <summary>
    /// Represents a node in the binary search tree
    /// </summary>
    /// <typeparam name="T">Type of data stored in the node, must be comparable</typeparam>
    public class BinaryTree<T> where T : IComparable<T>
    {
        /// <summary>
        /// The root value of this tree/subtree
        /// </summary>
        public T Root { get; private set; }

        /// <summary>
        /// Left subtree (all values ≤ Root)
        /// </summary>
        public BinaryTree<T> LeftSubtree { get; private set; }

        /// <summary>
        /// Right subtree (all values > Root)
        /// </summary>
        public BinaryTree<T> RightSubtree { get; private set; }

        /// <summary>
        /// Constructs a new binary tree with the specified root value
        /// </summary>
        /// <param name="rootValue">The value for the root node</param>
        public BinaryTree(T rootValue)
        {
            Root = rootValue;
            LeftSubtree = null;
            RightSubtree = null;
        }

        /// <summary>
        /// Inserts a new value into the binary search tree
        /// </summary>
        /// <param name="value">The value to insert</param>
        public void Insert(T value)
        {
            int comparison = value.CompareTo(Root);

            if (comparison <= 0)  // Value is less than or equal to current node
            {
                if (LeftSubtree == null)
                {
                    Console.WriteLine($"Inserting {value} as left child of {Root}");
                    LeftSubtree = new BinaryTree<T>(value);
                }
                else
                {
                    LeftSubtree.Insert(value);
                }
            }
            else  // Value is greater than current node
            {
                if (RightSubtree == null)
                {
                    Console.WriteLine($"Inserting {value} as right child of {Root}");
                    RightSubtree = new BinaryTree<T>(value);
                }
                else
                {
                    RightSubtree.Insert(value);
                }
            }
        }

        /// <summary>
        /// Performs an in-order traversal of the tree (left-root-right)
        /// </summary>
        public void TraverseInOrder()
        {
            Console.WriteLine($"Entering node: {Root}");

            if (LeftSubtree != null)
            {
                Console.WriteLine($"Moving left from {Root}");
                LeftSubtree.TraverseInOrder();
            }

            Console.WriteLine($"Processing value: {Root}");

            if (RightSubtree != null)
            {
                Console.WriteLine($"Moving right from {Root}");
                RightSubtree.TraverseInOrder();
            }
        }

        /// <summary>
        /// Performs a pre-order traversal of the tree (root-left-right)
        /// </summary>
        public void TraversePreOrder()
        {
            Console.WriteLine($"Processing value: {Root}");

            if (LeftSubtree != null)
            {
                Console.WriteLine($"Moving left from {Root}");
                LeftSubtree.TraversePreOrder();
            }

            if (RightSubtree != null)
            {
                Console.WriteLine($"Moving right from {Root}");
                RightSubtree.TraversePreOrder();
            }
        }

        /// <summary>
        /// Performs a post-order traversal of the tree (left-right-root)
        /// </summary>
        public void TraversePostOrder()
        {
            if (LeftSubtree != null)
            {
                Console.WriteLine($"Moving left from {Root}");
                LeftSubtree.TraversePostOrder();
            }

            if (RightSubtree != null)
            {
                Console.WriteLine($"Moving right from {Root}");
                RightSubtree.TraversePostOrder();
            }

            Console.WriteLine($"Processing value: {Root}");
        }

        /// <summary>
        /// Searches for a value in the tree
        /// </summary>
        /// <param name="value">The value to search for</param>
        /// <returns>True if the value exists in the tree, false otherwise</returns>
        public bool Contains(T value)
        {
            int comparison = value.CompareTo(Root);

            if (comparison == 0)
            {
                return true;
            }
            else if (comparison < 0 && LeftSubtree != null)
            {
                return LeftSubtree.Contains(value);
            }
            else if (comparison > 0 && RightSubtree != null)
            {
                return RightSubtree.Contains(value);
            }

            return false;
        }
    }

    /// <summary>
    /// Test class for demonstrating the binary search tree
    /// </summary>
    class BinaryTreeDemo
    {
        public static void Main()
        {
            Console.WriteLine("Binary Search Tree Demonstration");
            Console.WriteLine("===============================");

            // Integer tree demonstration
            Console.WriteLine("\nCreating integer tree:");
            BinaryTree<int> intTree = new BinaryTree<int>(8);
            intTree.Insert(7);
            intTree.Insert(2);
            intTree.Insert(9);
            intTree.Insert(20);
            intTree.Insert(11);
            intTree.Insert(3);

            Console.WriteLine("\nIn-order traversal:");
            intTree.TraverseInOrder();

            Console.WriteLine("\nPre-order traversal:");
            intTree.TraversePreOrder();

            Console.WriteLine("\nPost-order traversal:");
            intTree.TraversePostOrder();

            // String tree demonstration
            Console.WriteLine("\nCreating string tree:");
            BinaryTree<string> stringTree = new BinaryTree<string>("hello");
            stringTree.Insert("there");
            stringTree.Insert("binary");
            stringTree.Insert("trees");
            stringTree.Insert("algorithm");
            stringTree.Insert("demo");

            Console.WriteLine("\nIn-order traversal:");
            stringTree.TraverseInOrder();

            // Search demonstration
            Console.WriteLine("\nSearching for values:");
            Console.WriteLine($"Contains 11? {intTree.Contains(11)}");
            Console.WriteLine($"Contains 99? {intTree.Contains(99)}");
            Console.WriteLine($"Contains 'binary'? {stringTree.Contains("binary")}");
            Console.WriteLine($"Contains 'missing'? {stringTree.Contains("missing")}");
        }
    }
}