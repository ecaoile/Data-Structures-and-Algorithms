using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_with_Stacks.Classes
{
    public class Stack
    {
        /// <summary>
        /// the top of a stack
        /// </summary>
        public Node Top { get; set; }

        /// <summary>
        /// constructor for a stack that requires a node
        /// </summary>
        /// <param name="node">the node object to be put into the stack</param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// pushes a node onto the top of the stack
        /// </summary>
        /// <param name="newNode"></param>
        public Node Push(Node newNode)
        {
            //Console.WriteLine($"Adding {newNode.Value} to the stack.");
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
            //Console.WriteLine($"Popping off {Top.Value} from the stack!");
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
            Node Current = Top;
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

        /// <summary>
        /// Emulates the "enqueue" method but for a stack
        /// </summary>
        /// <param name="value">the value of the node to "enqueue"</param>
        /// <returns>The node that was "enqueued"</returns>
        public Node Enqueue(int value)
        {
            Push(new Node(value));
            return Top;
        }

        /// <summary>
        /// emulates the "dequeue" method but for a stack
        /// </summary>
        /// <returns>the node that was "dequeued" from the stack</returns>
        public Node Dequeue()
        {
            Stack tmpStack = new Stack(Pop());

            while (Top.Next != null)
                tmpStack.Push(Pop());

            Node tmpNode = Pop();

            while (tmpStack.Top != null)
                Push(tmpStack.Pop());

            return tmpNode;
        }
    }
}
