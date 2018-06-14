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

            Console.WriteLine("Here is your second linked list:");
            ll2.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Here is your merged list:");
            SinglyLinkedList ll3 = Merge(ll1, ll2);
            ll3.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Thank you for playing! Press enter to exit.");
            Console.ReadLine();
        }

        public static SinglyLinkedList Merge(SinglyLinkedList ll1, SinglyLinkedList ll2)
        {
            ll1.Current = ll1.Head;
            ll2.Current = ll2.Head;
            SinglyLinkedList ll3 = new SinglyLinkedList(new Node(ll1.Current.Value));
            int counter = 1;
            while (ll1.Current.Next != null && ll2.Current.Next != null)
            {
                if (ll1.Current.Next != null && counter % 2 == 0)
                {
                    ll1.Current = ll1.Current.Next;
                }

                if (ll2.Current.Next != null && counter % 2 != 0)
                {
                    ll1.AddAfter(new Node(ll2.Current.Value), new Node(ll1.Current.Value));
                    ll1.Current = ll1.Current.Next;
                    ll2.Current = ll2.Current.Next;
                }
                counter++;
            }

            while (ll2.Current != null)
            {
                ll1.AddLast(new Node(ll2.Current.Value));
                ll2.Current = ll2.Current.Next;
            }

            return ll1;
        }
    }
}
