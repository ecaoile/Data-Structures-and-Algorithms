using System;
using System.Collections.Generic;
using GetEdges.Classes;

namespace GetEdges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node node1 = new Node("Narnia");
            Node node2 = new Node("Metroville");
            Node node3 = new Node("Naboo");
            Node node4 = new Node("Monstropolis");

            Graph datGraph = new Graph();
            datGraph.AddEdge(node1, node2, 37);
            datGraph.AddEdge(node1, node3, 250);
            datGraph.AddEdge(node2, node3, 26);
            datGraph.AddEdge(node3, node4, 73);

            var path1 = datGraph.BreadthFirst(node1);

            Console.WriteLine("Here is your flight path:");
            foreach (var item in path1)
            {
                Console.Write($"{item.Name} ---> ");
            }

            Console.WriteLine("\n");
            List<Node> flightPath1 = new List<Node> { node1, node2, node3, node4 };

            Console.WriteLine(datGraph.GetEdges(flightPath1).Value); 

            Console.WriteLine("Let's try a path that shouldn't work:");

            List<Node> flightPath2 = new List<Node> { node1, node4 };

            Console.WriteLine(datGraph.GetEdges(flsdightPath2).Value);

            Console.WriteLine("\nThank you for watching. Press any button to exit.");
            Console.ReadKey();
        }
    }
}
