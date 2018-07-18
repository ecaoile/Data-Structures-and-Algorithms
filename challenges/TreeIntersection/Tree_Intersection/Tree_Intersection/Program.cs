using System;
using System.Collections.Generic;
using Tree_Intersection.Classes;

namespace Tree_Intersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 32!");
            Node datBST1Root = new Node(150);
            BinarySearchTree datBST1 = new BinarySearchTree(datBST1Root);
            datBST1.Add(datBST1Root, 100);
            datBST1.Add(datBST1Root, 250);
            datBST1.Add(datBST1Root, 75);
            datBST1.Add(datBST1Root, 160);
            datBST1.Add(datBST1Root, 200);
            datBST1.Add(datBST1Root, 175);
            datBST1.Add(datBST1Root, 350);
            datBST1.Add(datBST1Root, 125);
            datBST1.Add(datBST1Root, 300);
            datBST1.Add(datBST1Root, 500);

            List<int> datNumList1 = datBST1.BreadthFirstList(datBST1Root);
            Console.WriteLine("\nHere are your numbers from the first list:");
            Print(datNumList1);

            Node datBST2Root = new Node(42);
            BinarySearchTree datBST2 = new BinarySearchTree(datBST2Root);
            datBST2.Add(datBST2Root, 100);
            datBST2.Add(datBST2Root, 600);
            datBST2.Add(datBST2Root, 4);
            datBST2.Add(datBST2Root, 15);
            datBST2.Add(datBST2Root, 160);
            datBST2.Add(datBST2Root, 125);
            datBST2.Add(datBST2Root, 175);
            datBST2.Add(datBST2Root, 200);
            datBST2.Add(datBST2Root, 300);
            datBST2.Add(datBST2Root, 350);
            datBST2.Add(datBST2Root, 500);

            List<int> datNumList2 = datBST2.BreadthFirstList(datBST2Root);
            Console.WriteLine("\nHere are your numbers from the second list:");
            Print(datNumList2);

            TreeIntersection(datBST1, datBST2);
            Console.WriteLine("\nThank you for watching! Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// takes two binary search trees and returns a list of common int values between the two
        /// </summary>
        /// <param name="datBST1">first BST</param>
        /// <param name="datBST2">second BST</param>
        /// <returns>a list of common int values</returns>
        public static List<int> TreeIntersection(BinarySearchTree datBST1, BinarySearchTree datBST2)
        {
            List<int> demNums1 = datBST1.BreadthFirstList(datBST1.Root);
            List<int> treeIntersection = new List<int>();

            foreach (int num in demNums1)
            {
                var result = datBST2.Search(datBST2.Root, num);
                if (result != null)
                    treeIntersection.Add(result.Value);
            }

            Console.WriteLine("\nHere's your list of common numbers:");
            Print(treeIntersection);

            return demNums1;
        }

        public static void Print(List<int> datIntList)
        {
            Console.Write("[ ");
            foreach (int num in datIntList)
            {
                Console.Write($"{num} ");
            }
            Console.Write("]\n");
        }
    }
}
