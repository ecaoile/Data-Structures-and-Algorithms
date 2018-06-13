using System;
using KthElement.Classes;

namespace KthElement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 07!");
            
            try
            {
                int k = 2;
                int datNodeValue1 = KthElement(k).Value;
                Console.WriteLine("\n");
                Console.WriteLine($"We are going to print out the value of the node that is {k} nodes" +
                    " away from the last node.");
                Console.WriteLine(datNodeValue1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error trying to get a valid node value.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nThank you for playing. Press enter to exit.");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// method that finds the node that k nodes from the last node
        /// </summary>
        /// <param name="k">an integer amount to count from the last node</param>
        /// <returns>target node</returns>
        public static Node KthElement(int k)
        {
            SinglyLinkedList datLL = new SinglyLinkedList(new Node(42));
            datLL.Add(new Node(24));
            datLL.Add(new Node(12));

            // we should now print 12 --> 24 --> 42
            Console.WriteLine("\nHere is our starting linked list:");
            datLL.Print();

            try
            {
                datLL.Current = datLL.Head;
                Node runner = datLL.Head;
                int counter = 0;
                while (runner.Next != null)
                {
                    counter++;
                    runner = runner.Next;
                    if (counter > k)
                        datLL.Current = datLL.Current.Next;
                }
                if (k > counter)
                {
                    Console.WriteLine("Error: k out of range");
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return datLL.Current;
        }
    }
}
