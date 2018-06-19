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

            Console.WriteLine("\nNow let's 'enqueue' another value");
            stack1.Enqueue(5);
            stack1.Print();

            Console.WriteLine("\nNow let's 'dequeue' a value");
            stack1.Dequeue();
            stack1.Print();
        }
    }
}
