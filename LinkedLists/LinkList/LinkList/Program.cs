using System;

namespace LinkList
{
    /// <summary>
    /// class that runs the main program
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my humble singly linked list implementation!");
            TestLL();
            Console.WriteLine("Thank you for watching. Press any button to exit.");
            Console.ReadLine();
        }
        /// <summary>
        /// method that displays the nodes in console along with add methods
        /// </summary>
        static void TestLL()
        {
            SinglyLinkedList datLL = new SinglyLinkedList(new Node(55));
            datLL.Add(new Node(42));
            datLL.Add(new Node(11));

            // printing out starting value first
            Console.WriteLine("\nHere are our starting values for reference:");
            datLL.Print();
            Console.WriteLine();
            Console.WriteLine("\nLet's find node 42");
            Node found = datLL.Find(42);
            Console.WriteLine(found.Value);

            //let's add a node before 42
            Console.WriteLine("\nLet's add a node before 42.");
            datLL.AddBefore(new Node(24), new Node(42));
            datLL.Print();
            Console.WriteLine();

            // let's add another node after 24
            Console.WriteLine("\nLet's add a node after 24");
            datLL.AddAfter(new Node(35), new Node(24));
            datLL.Print();
            Console.WriteLine();

            // let's add another node to the end
            Console.WriteLine("\nLet's add a node after 55");
            datLL.AddLast(new Node(345));
            datLL.Print();
            Console.WriteLine();
        }
    }
}
