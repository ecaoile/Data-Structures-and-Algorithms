using System;
using FindMaxBinaryTree.Classes;

namespace FindMaxBinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 18\n!");

            Node datRoot = new Node(2);
            BinaryTree datTree = new BinaryTree(datRoot);
            datTree.Root.LeftChild = new Node(7);
            datTree.Root.LeftChild.LeftChild = new Node(2);
            datTree.Root.LeftChild.RightChild = new Node(6);
            datTree.Root.LeftChild.RightChild.LeftChild = new Node(5);
            datTree.Root.LeftChild.RightChild.RightChild = new Node(11);
            datTree.Root.RightChild = new Node(5);
            datTree.Root.RightChild.RightChild = new Node(9);
            datTree.Root.RightChild.RightChild.LeftChild = new Node(4);

            Console.WriteLine("Let's start off with a binary tree. Here's what it looks like:");
            datTree.BreadthFirst(datRoot);

            Console.WriteLine("\nLet's find the maximum value of this tree!");
            Console.WriteLine($"The maximum value is {datTree.FindMax(datRoot)}");

            Console.WriteLine("\nThank you for watching. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
