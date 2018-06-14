using System;
using System.Collections.Generic;
using System.Text;

namespace ll_merge.Classes
{
    /// <summary>
    /// Linked list class
    /// </summary>
    public class SinglyLinkedList
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
        public SinglyLinkedList(Node node)
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
        public void Print()
        {
            // guarantees that we start at the beginning
            Current = Head;
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} ---> ");
                Current = Current.Next;
            }
            // when we break out of the while loop, we'll be at the last node
            Console.Write($"{Current.Value} ---> NULL");
        }

        /// <summary>
        /// finds a node with a specified value
        /// </summary>
        /// <param name="value">value of node to find</param>
        /// <returns>the node that contains the value</returns>
        public Node Find(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                // I want you to go ahead and return the current node
                // Otherwise, set current to current.next
                if (Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }
            // if current is equal to value, go ahead and return the current. Otherwise, return null (last node)
            // don't want to return a node if there is no node to give
            return Current.Value == value ? Current : null;
        }
        
        /// <summary>
        /// method that adds a node before an existing node
        /// </summary>
        /// <param name="newNode">the new node to add</param>
        /// <param name="existingNode">a dummy node with the same value as 
        /// an existing node (not the actual node)</param>
        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
            Current = Current.Next;
            }
        }

        /// <summary>
        /// method that adds a new node after an existing node
        /// </summary>
        /// <param name="newNode">the new node to add</param>
        /// <param name="existingNode">a dummy node with the same value as 
        /// an existing node (not the actual node)</param>
        public void AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

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
            return;  
        }

        /// <summary>
        /// merges two linked list together
        /// </summary>
        /// <param name="ll1">the first link list</param>
        /// <param name="ll2">the second linked list to merge into the first</param>
        /// <returns>the first linked list as a merge of the original two</returns>
        public SinglyLinkedList Merge(SinglyLinkedList ll1, SinglyLinkedList ll2)
        {
            ll1.Current = ll1.Head;
            ll2.Current = ll2.Head;
            SinglyLinkedList ll3 = new SinglyLinkedList(new Node(ll1.Current.Value));
            int counter = 1;
            while (ll1.Current.Next != null && ll2.Current.Next != null)
            {
                if (ll1.Current.Next != null && counter % 2 == 0)
                {
                    ll1.Current = ll1.Current.Next;
                }

                if (ll2.Current.Next != null && counter % 2 != 0)
                {
                    ll1.AddAfter(new Node(ll2.Current.Value), new Node(ll1.Current.Value));
                    ll1.Current = ll1.Current.Next;
                    ll2.Current = ll2.Current.Next;
                }
                counter++;
            }

            while (ll2.Current != null)
            {
                ll1.AddLast(new Node(ll2.Current.Value));
                ll2.Current = ll2.Current.Next;
            }

            return ll1;
        }
    }
}
