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
            Console.WriteLine("Hello World!");
            TestLL();
            Console.ReadLine();
        }
        /// <summary>
        /// method that displays the nodes in console along with add methods
        /// </summary>
        static void TestLL()
        {
            SinglyLinkedList datLL = new SinglyLinkedList(new Node(555));
            datLL.Add(new Node(5));
            datLL.Add(new Node(10));
            
            // We should see this print out in the console: 10 -> 5 -> 555
            datLL.Print();
            Console.WriteLine();
            Console.WriteLine("\nLet's find node 5");
            Node found = datLL.Find(5);
            Console.WriteLine(found.Value);

            //let's add a node before 5
            Console.WriteLine("\nLet's add a node before 5.");
            datLL.AddBefore(new Node(12), new Node(5));
            datLL.Print();
            Console.WriteLine();

            // let's add another node after 12
            Console.WriteLine("\nLet's add a node after 12");
            datLL.AddAfter(new Node(123), new Node(12));
            datLL.Print();
            Console.WriteLine();

            // let's add another node to the end
            Console.WriteLine("\nLet's add a node after 5");
            datLL.AddLast(new Node(345));
            datLL.Print();
            Console.WriteLine();
        }
    }
}
