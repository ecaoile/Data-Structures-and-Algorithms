using System;
using ll_merge.Classes;

namespace ll_merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 08!\n");

            SinglyLinkedList ll1 = new SinglyLinkedList(new Node(1));
            ll1.AddLast(new Node(3));
            ll1.AddLast(new Node(9));

            Console.WriteLine("Here is your first linked list:");
            ll1.Print();
            Console.WriteLine("\n");

            SinglyLinkedList ll2 = new SinglyLinkedList(new Node(5));
            ll2.AddLast(new Node(2));
            ll2.AddLast(new Node(4));
            ll2.AddLast(new Node(7));
            ll2.AddLast(new Node(11));

            Console.WriteLine("Here is your second linked list:");
            ll2.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Here is your merged list:");
            ll1.Merge(ll1, ll2);
            ll1.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Thank you for playing! Press enter to exit.");
            Console.ReadLine();
        }

    }
}
