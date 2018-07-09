using System;
using System.Collections.Generic;
using GraphImplementation.Classes;

namespace GraphImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Graph Implementation!\n");

            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");

            // For reference, I am recreating the same graph that is
            // show on Amanda's adjacency list example
            Graph datGraph = new Graph();
            // A -> C -> F
            Console.WriteLine(datGraph.AddEdge(nodeA, nodeC).Value);
            Console.WriteLine(datGraph.AddEdge(nodeC, nodeD).Value);

            // B -> C -> F
            Console.WriteLine(datGraph.AddEdge(nodeB, nodeC).Value);
            Console.WriteLine(datGraph.AddEdge(nodeC, nodeF).Value);

            // C -> A -> B -> E
            Console.WriteLine(datGraph.AddEdge(nodeC, nodeA).Value);
            Console.WriteLine(datGraph.AddEdge(nodeA, nodeB).Value);
            Console.WriteLine(datGraph.AddEdge(nodeB, nodeE).Value);

            // D -> A -> E
            Console.WriteLine(datGraph.AddEdge(nodeD, nodeA).Value);
            Console.WriteLine(datGraph.AddEdge(nodeA, nodeE).Value);

            // E -> C -> D -> F
            Console.WriteLine(datGraph.AddEdge(nodeE, nodeC).Value);
            Console.WriteLine(datGraph.AddEdge(nodeC, nodeD).Value);
            Console.WriteLine(datGraph.AddEdge(nodeD, nodeF).Value);

            // F -> B -> E
            Console.WriteLine(datGraph.AddEdge(nodeF, nodeB).Value);
            Console.WriteLine(datGraph.AddEdge(nodeB, nodeE).Value);

            List<Node> graphList = datGraph.GetNodes(nodeA);

            Console.WriteLine("\nLet's look at all of the nodes in the graph!");
            foreach (Node item in graphList)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("Let's get the neighbors of node A.");
            List<Node> aNeighbors = datGraph.GetNeighbors(nodeA);
            foreach (Node item in aNeighbors)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("\nLet's get the number of nodes in our graph:");
            Console.WriteLine(datGraph.GetSize(nodeA)); 
            Console.WriteLine("\nThank you for watching! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
