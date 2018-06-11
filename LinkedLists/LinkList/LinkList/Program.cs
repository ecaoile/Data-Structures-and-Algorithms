using System;

namespace LinkList
{
    class Program
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
            LinkList datLL = new LinkList(new Node(555));
            datLL.Add(new Node(5));
            datLL.Add(new Node(10));
            
            // We should see this print out in the console: 10 -> 5 -> 555
            datLL.Print();

            Console.WriteLine("\nLet's find node 5");
            Node found = datLL.Find(5);
            Console.WriteLine(found.Value);
        }
    }
}
