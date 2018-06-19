using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_with_Stacks.Classes
{
    public class Queue
    {
        /// <summary>
        /// taking in 2 stacks as our constructor for our "queue"
        /// </summary>
        public Stack Stack1 { get; set; }
        public Stack Stack2 { get; set; }

        /// <summary>
        /// constructor for our "queue" that requires 2 stacks
        /// </summary>
        /// <param name="node">the node object to be put into the stack</param>
        public Queue(Stack stack1, Stack stack2)
        {
            Stack1 = stack1;
            Stack2 = stack2;
        }

        /// <summary>
        /// prints out nodes in a stack
        /// </summary>
        public void Print()
        {
            // guarantees that we start at the top
            Node Current = Stack1.Top;
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
        /// Emulates the "enqueue" method using a stack
        /// </summary>
        /// <param name="value">the value of the node to "enqueue"</param>
        /// <returns>The node that was "enqueued"</returns>
        public Node Enqueue(int value)
        {
            Stack1.Push(new Node(value));
            return Stack1.Top;
        }

        /// <summary>
        /// emulates the "dequeue" method using 2 stacks
        /// </summary>
        /// <returns>the node that was "dequeued" from the stack</returns>
        public Node Dequeue()
        {
            if (Stack1.Top.Next == null)
                return Stack1.Pop();
            while (Stack1.Top.Next != null)
                Stack2.Push(Stack1.Pop());

            Node tmpNode = Stack1.Pop();

            while (Stack2.Top.Next != null)
                Stack1.Push(Stack2.Pop());

            return tmpNode;
        }
    }
}
