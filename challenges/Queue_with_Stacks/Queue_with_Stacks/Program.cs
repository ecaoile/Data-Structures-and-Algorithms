using System;
using Queue_with_Stacks.Classes;

namespace Queue_with_Stacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to whiteboard challenge 11.\n");
            QueueWithStack();
            Console.WriteLine("\nThank you for playing! Press any button to quit.");
            Console.ReadKey();
        }

        public static void QueueWithStack()
        {
            Console.WriteLine("Here is what your original stack looks like:");
            Stack stack1 = new Stack(new Node(20));
            stack1.Push(new Node(15));
            stack1.Push(new Node(10));
            stack1.Print();

            Stack stack2 = new Stack(new Node(0));
            Queue fakeQueue = new Queue(stack1, stack2);
            Console.WriteLine("\nNow let's 'enqueue' another value");
            fakeQueue.Enqueue(5);
            fakeQueue.Print();

            Console.WriteLine("\nNow let's 'dequeue' a value");
            fakeQueue.Dequeue();
            fakeQueue.Print();
        }
    }
}
