using System;
using System.Collections.Generic;
using System.Text;

namespace BT_and_BST.Classes
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
            if (value == root.Value)
                return false;

            Node datNode = new Node(value);
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.WriteLine(front.Value);

                if (value == front.Value)
                    return false;

                if (value < front.Value)
                {
                    if (front.LeftChild == null)
                    {
                        front.LeftChild = datNode;
                        Console.WriteLine($"Added {value} to the left of {front.Value}.");
                        return true;
                    }
                    else
                    {
                        breadth.Enqueue(front.LeftChild);
                    }
                }
                
                if (value > front.Value)
                {
                    if (front.RightChild == null)
                    {
                        front.RightChild = datNode;
                        Console.WriteLine($"Added {value} to the right of {front.Value}");
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
        /// deletes a node from the tree and re-organizes the tree as needed to meet BST requirements
        /// </summary>
        /// <param name="root">root of the BST</param>
        /// <param name="key">value of the node to delete</param>
        /// <returns>deleted node</returns>
        public Node Delete(Node root, double key)
        {
            if (root == null) return null;

            // delete from the right subtree
            if (key > Root.Value) root.RightChild = Delete(root.RightChild, key);

            // delete from the left subtree
            else if (key < root.Value) root.LeftChild = Delete(root.LeftChild, key);

            else
            {
                // the node is a leaf
                if (root.LeftChild == null && root.RightChild == null) root = null;
                else if (root.RightChild != null)
                {
                    root.Value = Successor(root);
                    root.RightChild = Delete(Root.RightChild, root.Value);
                }
                else
                {
                    root.Value = Predecessor(root);
                    root.LeftChild = Delete(root.LeftChild, root.Value);
                }
            }
            return root;
        }

        /// <summary>
        /// helper method to hold the left child value
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public double Predecessor(Node root)
        {
            root = root.LeftChild;
            while (root.RightChild != null) root = root.RightChild;
            return root.Value;
        }

        /// <summary>
        /// helper method to hold the right child value
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public double Successor(Node root)
        {
            root = root.RightChild;
            while (root.LeftChild != null) root = root.LeftChild;
            return root.Value;
        }

        /// <summary>
        /// searches for the value of a node in a tree
        /// </summary>
        /// <param name="root">the root node to start at</param>
        /// <param name="value"></param>
        /// <returns>the node if it was found</returns>
        public Node Search(Node root, int value)
        {
            if (root != null)
            {
                Node datNode = new Node(value);
                if (value == root.Value)
                {
                    Console.WriteLine($"Found a match with the value {root.Value}!");
                    return root;
                }

                if (value < root.Value)
                    return Search(root.LeftChild, value);

                if (value > root.Value)
                    return Search(root.RightChild, value);
            }

            Console.WriteLine("Sorry, but we could not find a match!");
            return null;
        }
    }
}
