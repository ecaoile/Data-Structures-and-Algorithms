using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxBinaryTree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node node)
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
        /// adds a node to the first vacant spot using breadth first traversal
        /// </summary>
        /// <param name="root">the root node to start at</param>
        /// <param name="value">the value of the node to add</param>
        /// <returns>boolean determining whether the add was successful</returns>
        public bool Add(Node root, int value)
        {
            Node datNode = new Node(value);
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.WriteLine(front.Value);

                if (front.LeftChild == null)
                {
                    front.LeftChild = datNode;
                    Console.WriteLine($"Added {value} to the left of {front.Value}.");
                    return true;
                }

                if (front.RightChild == null)
                {
                    front.RightChild = datNode;
                    Console.WriteLine($"Added {value} to the right of {front.Value}");
                    return true;
                }

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }

                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return false;
        }

        /// <summary>
        /// searches for the value of a node in a tree
        /// </summary>
        /// <param name="root">the root node to start at</param>
        /// <param name="value"></param>
        /// <returns>the node if it was found</returns>
        public Node Search(Node root, int value)
        {
            if (root == null)
            {
                Console.WriteLine("Sorry, but we could not find a match!");
                return null;
            }

            if (root.Value == value)
            {
                Console.WriteLine($"Found a match with the value {value}!");
                return root;
            }
            // ?? means evalute the left side if it is not null and evaluate the
            // right side if the left side is null
            return Search(root.LeftChild, value) ?? Search(root.RightChild, value);
        }
        
        /// <summary>
        /// finds the max node value in a tree
        /// </summary>
        /// <param name="root">the root of a given tree to traverse</param>
        /// <returns>the max node value in the tree</returns>
        public double FindMax(Node root)
        {
            double datMax = root.Value;
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);
            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                if (front.Value > datMax)
                {
                    datMax = front.Value;
                }

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild); 
                }

                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return datMax;
        }
    }
}
