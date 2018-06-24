using System;
using BT_and_BST.Classes;

namespace BT_and_BST
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node datRoot = new Node(3);
            BinaryTree datBinaryTree = new BinaryTree(datRoot);

            Console.WriteLine("Let's try adding a few nodes now.");
            datBinaryTree.Add(datRoot, 5);
            datBinaryTree.Add(datRoot, 7);
            datBinaryTree.Add(datRoot, 10);
            datBinaryTree.Add(datRoot, 13);
            datBinaryTree.Add(datRoot, 15);

            Console.WriteLine("\nInOrder traversal:");
            datBinaryTree.InOrder(datRoot);

            Console.WriteLine("\nPreOrder traversal:");
            datBinaryTree.PreOrder(datRoot);

            Console.WriteLine("\nPostOrder traversal:");
            datBinaryTree.PostOrder(datRoot);

            Console.WriteLine("\nBreadthFirst traversal:");
            datBinaryTree.BreadthFirst(datRoot);

            Console.WriteLine("\nLet's look for existing nodes.");
            Console.WriteLine(datBinaryTree.Search(datRoot, 10).Value);
            Console.WriteLine(datBinaryTree.Search(datRoot, 7).Value);

            Console.WriteLine("\nNext, let's make a binary search tree.");
            Node datBSTRoot = new Node(100);
            BinarySearchTree datBST = new BinarySearchTree(datBSTRoot);
            datBST.Add(datBSTRoot, 200);
            datBST.Add(datBSTRoot, 50);
            datBST.Add(datBSTRoot, 25);
            datBST.Add(datBSTRoot, 75);
            datBST.Add(datBSTRoot, 300);
            datBST.Add(datBSTRoot, 150);
            datBST.Add(datBSTRoot, 342);
            datBST.Add(datBSTRoot, 90);
            datBST.Add(datBSTRoot, 60);

            Console.WriteLine("\nLet's look for existing nodes.");
            datBST.Search(datBSTRoot, 25);
            datBST.Search(datBSTRoot, 75);

            Console.WriteLine("\nThank you for watching! Press any button to exit.");
            Console.ReadKey();
        }

    }
}
