using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// traverses a binary tree, printing out the values in "root, left, right" order
        /// </summary>
        /// <param name="node">the root node to start at</param>
        public void PreOrder(Node node)
        {
            Console.WriteLine(node.Pair.Key);

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

            Console.WriteLine(node.Pair.Key);

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

            Console.WriteLine(node.Pair.Key);
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
                Console.WriteLine(front.Pair.Value);

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
        public bool Add(Node root, string key, int value)
        {
            if (key == root.Pair.Key)
                return false;

            Node datNode = new Node(key, value);
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.WriteLine(front.Pair.Key);

                if (value == front.Pair.Value)
                {
                   if (key == front.Pair.Key)
                    {
                        front.Count++;
                        return true;
                    }
                   if (front.LeftChild == null)
                    {
                        front.LeftChild = datNode;
                    }
                   else
                   {
                        breadth.Enqueue(front.LeftChild);
                   }
                }

                if (value < front.Pair.Value)
                {
                    if (front.LeftChild == null)
                    {
                        front.LeftChild = datNode;
                        Console.WriteLine($"Added {datNode.Pair.Value} to the left of {front.Pair.Value}.");
                        return true;
                    }
                    else
                    {
                        breadth.Enqueue(front.LeftChild);
                    }
                }
                
                if (value > front.Pair.Value)
                {
                    if (front.RightChild == null)
                    {
                        front.RightChild = datNode;
                        Console.WriteLine($"Added {datNode.Pair.Value} to the right of {front.Pair}");
                        return true;
                    }
                    else
                    {
                        breadth.Enqueue(front.RightChild);
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// searches for the value of a node in a tree (refactored from
        /// original search)
        /// </summary>
        /// <param name="root">the root node to start at</param>
        /// <param name="key">the key in a node's key value pair</param>
        /// <returns>the value of the Node if it was found</returns>
        public int Search(Node root, string key)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                if (front.Pair.Key == key)
                {
                    Console.WriteLine($"Found a node: [{front.Pair.Key}," +
                        $" {front.Pair.Value}]");
                    return front.Pair.Value;
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
            return 0;
        }
    }
}
