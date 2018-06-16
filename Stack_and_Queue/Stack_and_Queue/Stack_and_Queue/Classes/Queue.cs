using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Queue
    {
        /// <summary>
        /// the front of a queue
        /// </summary>
        public Node Front { get; set; }

        public Node Rear { get; set; }

        // We're going to be traversing through this list, so we need a current
        public Node Current { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
            Current = node;
        }

        public void Enqueue(Node newNode)
        {
            Console.WriteLine($"Adding {newNode.Value} to the queue.");
            newNode.Next = Rear;
            Rear = newNode;
        }

        public Node Dequeue()
        {
            Console.WriteLine($"Removing {Front.Value} from the queue.");
            Node tmp = Front;
            Front = Front.Next;
            tmp.Next = null;
            return tmp;
        }

        public Node Peek()
        {
            return Front;
        }

        /// <summary>
        /// prints out nodes in a stack
        /// </summary>
        public void Print()
        {
            // start from the rear to print everything up to the front
            Current = Rear;
            Console.Write("REAR ---> ");
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} ---> ");
                Current = Current.Next;
            }
            // when we break out of the while loop, we'll be at the last node
            Console.Write($"{Current.Value} ---> FRONT");
            Console.WriteLine();
        }

    }
}
