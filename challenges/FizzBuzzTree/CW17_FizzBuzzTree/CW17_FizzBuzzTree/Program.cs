using System;
using CW17_FizzBuzzTree.Classes;

namespace CW17_FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to whiteboard challenge 17!");
            Console.WriteLine("Let's start off by creating a tree.\n");

            Node datRoot = new Node("5");
            Tree datTree = new Tree(datRoot);
            datTree.Root.LeftChild = new Node("3");
            datTree.Root.RightChild = new Node("15");
            datTree.Root.LeftChild.LeftChild = new Node("7");
            datTree.Root.LeftChild.RightChild = new Node("1");
            datTree.Root.RightChild.RightChild = new Node("not a number");
            Console.WriteLine("Here's what your tree looks like:");
            datTree.BreadthFirst(datRoot);

            Console.WriteLine("\nLet's do some fizzbuzz on this tree!");
            datTree.FizzBuzzTree(datRoot);

            Console.WriteLine("\nHere's what your tree looks like after fizzbuzz:");
            datTree.BreadthFirst(datRoot);
   
            Console.WriteLine("\nThank you for watching. Press enter to exit.");
            Console.ReadKey();
        }
    }
}
