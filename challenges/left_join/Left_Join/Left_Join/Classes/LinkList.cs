using Left_Join.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Left_Join
{
    /// <summary>
    /// Linked list class
    /// </summary>
    public class LinkList
    {
        /// <summary>
        /// the head of the linked list
        /// </summary>
        public Node Head { get; set; }

        // We're going to be traversing through this list, so we need a current
        public Node Current { get; set; }
        
        /// <summary>
        /// constructor for linked list that requires a node
        /// </summary>
        /// <param name="node">the node object to be put into the linked list</param>
        public LinkList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Adds node with an O(1) implementation
        /// </summary>
        /// <param name="node"></param>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// prints out nodes
        /// </summary>
        //public List<Node> Print()
        //{
        //    // guarantees that we start at the beginning
        //    Current = Head;
        //    while (Current.Next != null)
        //    {
        //        Console.Write($"{Current.Value} ---> ");
        //        Current = Current.Next;
        //    }
        //    // when we break out of the while loop, we'll be at the last node
        //    Console.Write($"{Current.Value} ---> NULL");
        //}

        /// <summary>
        /// finds a node with a specified value
        /// </summary>
        /// <param name="value">value of node to find</param>
        /// <returns>the node that contains the value</returns>
        public Node Find(string word)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Key == word)
                    return Current;

                Current = Current.Next;
            }
            // if current is equal to value, go ahead and return the current. Otherwise, return null (last node)
            // don't want to return a node if there is no node to give
            return Current.Key == word ? Current : null;
        }
        
        /// <summary>
        /// method that adds a node before an existing node
        /// </summary>
        /// <param name="newNode">the new node to add</param>
        /// <param name="existingNode">a dummy node with the same value as 
        /// an existing node (not the actual node)</param>
        //public void AddBefore(Node newNode, Node existingNode)
        //{
        //    Current = Head;
        //    if (Head.Value == existingNode.Value)
        //    {
        //        Add(newNode);
        //        return;
        //    }
        //    while (Current.Next != null)
        //    {
        //        if (Current.Next.Value == existingNode.Value)
        //        {
        //            newNode.Next = Current.Next;
        //            Current.Next = newNode;
        //            return;
        //        }
        //    Current = Current.Next;
        //    }
        //}

        /// <summary>
        /// method that adds a new node after an existing node
        /// </summary>
        /// <param name="newNode">the new node to add</param>
        /// <param name="existingNode">a dummy node with the same value as 
        /// an existing node (not the actual node)</param>
        //public void AddAfter(Node newNode, Node existingNode)
        //{
        //    Current = Head;
        //    while (Current.Next != null)
        //    {
        //        if (Current.Value == existingNode.Value)
        //        {
        //            newNode.Next = Current.Next;
        //            Current.Next = newNode;
        //            return;
        //        }
        //        Current = Current.Next;
        //    }
        //}

        /// <summary>
        /// method that adds a new node to the end of a linked list
        /// </summary>
        /// <param name="newNode"></param>
        public void AddLast(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = newNode;
            Console.WriteLine($"Added [{newNode.Key},{newNode.Values}] behind [{Current.Key},{Current.Values}]");
            return;  
        }

        /// <summary>
        /// custom method that adds values to an existing key
        /// </summary>
        /// <param name="newNode"></param>
        public void AddValueToKey(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Key == newNode.Key)
                {
                    Current.Values.AddRange(newNode.Values);
                }
                Current = Current.Next;
            }

            if (Current.Key == newNode.Key)
            {
                Current.Values.AddRange(newNode.Values);
            }
        }
    }
}
