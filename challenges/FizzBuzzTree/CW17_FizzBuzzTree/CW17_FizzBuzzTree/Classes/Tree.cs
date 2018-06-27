using System;
using System.Collections.Generic;
using System.Text;

namespace CW17_FizzBuzzTree.Classes
{
    public class Tree
    {
        public Node Root { get; set; }

        public Tree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// traverses a binary tree, printing out the values in "root, left, right" order
        /// </summary>
        /// <param name="node">the root node to start at</param>
        public void PreOrder(Node node)
        {
            Console.WriteLine(node.Value);

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }

        /// <summary>
        /// traverses a binary tree, printing out the values in "left, root, right" order
        /// </summary>
        /// <param name="node">the root node to start at</param>
        public void InOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }

            Console.WriteLine(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
        }

        /// <summary>
        /// traverses a binary tree, printing out the values in "left, right root" order
        /// </summary>
        /// <param name="node">the root node to start at</param>
        public void PostOrder(Node node)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild);
            }

            if (node.RightChild != null)
            {
                PostOrder(node.RightChild);
            }

            Console.WriteLine(node.Value);
        }

        /// <summary>
        /// traverses through each "level" of a tree, going left to right
        /// </summary>
        /// <param name="node">the root node to start at</param>
        public void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.WriteLine(front.Value);
                
                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }

                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }

        /// <summary>
        /// traverses tree and replaces values that are divisible by 3, 5, or 3 and 5 and replaces them with
        /// "fizz", "buzz", or "fizzbuzz" respectively.
        /// </summary>
        /// <param name="root">the root node the tree</param>
        /// <returns>root node</returns>
        public Node FizzBuzzTree(Node root)
        {
            if (root == null)
            {
                Console.WriteLine($"Hitting the bottom of the tree.");
                return null;
            }

            int rootNum;
            bool isNum = Int32.TryParse(root.Value, out rootNum);

            if (!isNum)
            {
                Console.WriteLine($"'{root.Value}' is not a valid integer.");
            }

            else
            {
                if (rootNum % 3 == 0 && rootNum % 5 == 0)
                {
                    root.Value = "fizzbuzz";
                }

                else if (rootNum % 3 == 0)
                {
                    root.Value = "fizz";
                }

                else if (rootNum % 5 == 0)
                {
                    root.Value = "buzz";
                }

                else
                {
                    Console.WriteLine($"{root.Value} cannot be divided by 3 or 5.");
                }
            }

            return FizzBuzzTree(root.LeftChild) ?? FizzBuzzTree(root.RightChild);
        }
    }
}
