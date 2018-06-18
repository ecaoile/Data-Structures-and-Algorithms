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
        //public Node Current { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        public Node Enqueue(Node newNode)
        {
            Console.WriteLine($"Adding {newNode.Value} to the queue.");
            Rear.Next = newNode;
            Rear = newNode;
            return Rear;
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
        /// prints out nodes in a queue
        /// </summary>
        public void Print()
        {
            // start from the front to print everything going back

            Node Current = Front;

            Console.Write("Front ---> ");
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} ---> ");
                Current = Current.Next;
            }
            // when we break out of the while loop, we'll be at the last node
            Console.Write($"{Current.Value} ---> Rear");
            Console.WriteLine();
        }

    }
}
