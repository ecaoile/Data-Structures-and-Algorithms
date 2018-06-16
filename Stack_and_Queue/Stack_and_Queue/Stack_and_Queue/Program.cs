using System;
using Stack_and_Queue.Classes;

namespace Stack_and_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Here's your starting stack.");
            Stack datStack = new Stack(new Node(7));
            datStack.Print();

            Console.WriteLine("\nNow let's add a few nodes!");
            datStack.Push(new Node(14));
            datStack.Print();
            datStack.Push(new Node(20));
            datStack.Print();
            datStack.Push(new Node(42));
            datStack.Print();

            Console.WriteLine("\nNext, we'll make a queue.");
            Queue datQueue = new Queue(new Node(5));
            datQueue.Print();

            Console.WriteLine("\nNow let's add a few nodes!");
            datQueue.Enqueue(new Node(10));
            datQueue.Print();
            datQueue.Enqueue(new Node(20));
            datQueue.Print();
            datQueue.Enqueue(new Node(30));
            datQueue.Print();
            datQueue.Enqueue(new Node(40));
            datQueue.Print();
            //datQueue.Print();

            Console.WriteLine("\nLet's pop off the last two values from our stack.");
            datStack.Pop();
            datStack.Print();
            datStack.Pop();
            datStack.Print();

            Console.WriteLine("\nFinally, let's dequeue the first two items from our queue.");
            datQueue.Dequeue();
            datQueue.Print();
            datQueue.Dequeue();
            datQueue.Print();

            Console.WriteLine("\nThank you for watching. Press any key to quit.");
            Console.ReadKey();
        }
    }
}
