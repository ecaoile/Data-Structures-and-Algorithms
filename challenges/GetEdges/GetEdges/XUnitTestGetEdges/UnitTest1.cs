using System;
using Xunit;
using GetEdges.Classes;
using System.Collections.Generic;

namespace XUnitTestGetEdges
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
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
            datGraph.AddEdge(node3, node1, 250);

            var path1 = datGraph.BreadthFirst(node1);

            List<Node> flightPath1 = new List<Node> { node1, node2, node3, node4 };

            decimal fPath1Edges = datGraph.GetEdges(flightPath1);

            List<Node> flightPath2 = new List<Node> { node1, node4 };
            decimal fPath2Edges = datGraph.GetEdges(flightPath2);

            List<Node> flightPath3 = new List<Node> { node3, node1 };
            decimal fPath3Edges = datGraph.GetEdges(flightPath3);

            List<Node> flightPath4 = new List<Node> { node4 };
            decimal fPath4Edges = datGraph.GetEdges(flightPath4);

            Assert.Equal(136, fPath1Edges);
            Assert.Equal(0, fPath2Edges);
            Assert.Equal(250, fPath3Edges);
            Assert.Equal(0, fPath4Edges);
        }
    }
}
