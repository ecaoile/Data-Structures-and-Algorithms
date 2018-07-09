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

            // A -> C -> D
            Console.WriteLine(nodeA.Value);
            Console.WriteLine(datGraph.AddEdge(nodeA, nodeC).Value);
            Console.WriteLine(datGraph.AddEdge(nodeC, nodeD).Value);
            Console.WriteLine();

            // B -> C -> F
            Console.WriteLine(nodeB.Value);
            Console.WriteLine(datGraph.AddEdge(nodeB, nodeC).Value);
            Console.WriteLine(datGraph.AddEdge(nodeC, nodeF).Value);
            Console.WriteLine();

            // C -> A -> B -> E
            Console.WriteLine(nodeC.Value);
            Console.WriteLine(datGraph.AddEdge(nodeC, nodeA).Value);
            Console.WriteLine(datGraph.AddEdge(nodeA, nodeB).Value);
            Console.WriteLine(datGraph.AddEdge(nodeB, nodeE).Value);
            Console.WriteLine();

            // D -> A -> E
            Console.WriteLine(nodeD.Value);
            Console.WriteLine(datGraph.AddEdge(nodeD, nodeA).Value);
            Console.WriteLine(datGraph.AddEdge(nodeA, nodeE).Value);
            Console.WriteLine();

            // E -> C -> D -> F
            Console.WriteLine(nodeE.Value);
            Console.WriteLine(datGraph.AddEdge(nodeE, nodeC).Value);
            Console.WriteLine(datGraph.AddEdge(nodeC, nodeD).Value);
            Console.WriteLine(datGraph.AddEdge(nodeD, nodeF).Value);
            Console.WriteLine();

            // F -> B -> E
            Console.WriteLine(nodeF.Value);
            Console.WriteLine(datGraph.AddEdge(nodeF, nodeB).Value);
            Console.WriteLine(datGraph.AddEdge(nodeB, nodeE).Value);
            Console.WriteLine();

            List<Node> graphList = datGraph.GetNodes(nodeA);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.WriteLine("\nLet's look at all of the nodes in the graph!");
            foreach (Node item in graphList)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();

            Console.WriteLine("\nLet's get the neighbors of node A.");
            List<Node> aNeighbors = datGraph.GetNeighbors(nodeA);
            foreach (Node item in aNeighbors)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("\nLet's get the number of nodes in our graph:");
            Console.WriteLine(datGraph.Size(nodeA));

            Console.WriteLine("\nThank you for watching! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
