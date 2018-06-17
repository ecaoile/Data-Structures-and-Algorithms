﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Stack
    {
        /// <summary>
        /// the top of a stack
        /// </summary>
        public Node Top { get; set; }

        // We're going to be traversing through this stack, so we need a current
        public Node Current { get; set; }

        /// <summary>
        /// constructor for a stack that requires a node
        /// </summary>
        /// <param name="node">the node object to be put into the stack</param>
        public Stack(Node node)
        {
            Top = node;
            Current = node;
        }

        /// <summary>
        /// pushes a node onto the top of the stack
        /// </summary>
        /// <param name="newNode"></param>
        public Node Push(Node newNode)
        {
            Console.WriteLine($"Adding {newNode.Value} to the stack.");
            newNode.Next = Top;
            Top = newNode;
            return Top;
        }

        /// <summary>
        /// pops a node from the top of the stack
        /// </summary>
        /// <returns>the popped node</returns>
        public Node Pop()
        {
            Console.WriteLine($"Popping off {Top.Value} from the stack!");
            Node tmp = Top;
            Top = Top.Next;
            tmp.Next = null;
            return tmp;
        }

        /// <summary>
        /// peek at the top node of a stack
        /// </summary>
        /// <returns>top node</returns>
        public Node Peek()
        {
            return Top;
        }

        /// <summary>
        /// prints out nodes in a stack
        /// </summary>
        public void Print()
        {
            // guarantees that we start at the top
            Current = Top;
            Console.Write("TOP ---> ");
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} ---> ");
                Current = Current.Next;
            }
            // when we break out of the while loop, we'll be at the last node
            Console.Write($"{Current.Value} ---> NULL");
            Console.WriteLine();
        }
    }
}