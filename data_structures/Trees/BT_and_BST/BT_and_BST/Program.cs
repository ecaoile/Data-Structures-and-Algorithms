using System;
using BT_and_BST.Classes;

namespace BT_and_BST
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my binary tree and binary search" +
                "tree implementation.\n");
            Node datRoot = new Node(3);
            BinaryTree datBinaryTree = new BinaryTree(datRoot);

            Console.WriteLine("Let's try adding a few nodes now.");
            datBinaryTree.Add(datRoot, 5);
            datBinaryTree.Add(datRoot, 7);
            datBinaryTree.Add(datRoot, 10);
            datBinaryTree.Add(datRoot, 13);
            datBinaryTree.Add(datRoot, 15);

            // should display 3, 5, 10, 13, 7, 5
            Console.WriteLine("\nPreOrder traversal:");
            datBinaryTree.PreOrder(datRoot);

            // should display 10, 5, 13, 3, 15, 7
            Console.WriteLine("\nInOrder traversal:");
            datBinaryTree.InOrder(datRoot);

            // should display 10, 13, 5, 15, 7, 3
            Console.WriteLine("\nPostOrder traversal:");
            datBinaryTree.PostOrder(datRoot);

            // should display 3, 5, 7, 10, 13, 15
            Console.WriteLine("\nBreadthFirst traversal:");
            datBinaryTree.BreadthFirst(datRoot);

            Console.WriteLine("\nLet's look for existing nodes.");
            datBinaryTree.Search(datRoot, 10);
            datBinaryTree.Search(datRoot, 7);

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

            // should display 150, 50, 25, 75, 60, 90, 200, 150, 300, 342
            Console.WriteLine("\nPreorder traversal:");
            datBST.PreOrder(datBSTRoot);

            // should display 25, 50, 60, 75, 90, 100, 150, 200, 300, 342
            Console.WriteLine("\nInorder traversal:");
            datBST.InOrder(datBSTRoot);

            // should display 25, 60, 90, 75, 50, 150, 342, 300, 200, 100
            Console.WriteLine("\nPostorder traversal:");
            datBST.PostOrder(datBSTRoot);

            Console.WriteLine("\nLet's look for existing nodes.");
            datBST.Search(datBSTRoot, 25);
            datBST.Search(datBSTRoot, 75);

            Console.WriteLine("\nThank you for watching! Press any button to exit.");
            Console.ReadKey();
        }
    }
}
