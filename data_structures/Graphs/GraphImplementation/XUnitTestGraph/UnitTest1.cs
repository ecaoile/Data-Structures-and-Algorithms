using System;
using Xunit;
using GraphImplementation;
using GraphImplementation.Classes;

namespace XUnitTestGraph
{
    public class UnitTest1
    {
        /// <summary>
        /// tests the following: 
        /// 1. Size() returns the correct number of nodes back
        /// </summary>
        [Fact]
        public void CanGetSize()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");

            Graph datGraph = new Graph();

            // A -> C -> F
            datGraph.AddEdge(nodeA, nodeC);
            datGraph.AddEdge(nodeC, nodeD);

            // B -> C -> F
            datGraph.AddEdge(nodeB, nodeC);
            datGraph.AddEdge(nodeC, nodeF);

            // C -> A -> B -> E
            datGraph.AddEdge(nodeC, nodeA);
            datGraph.AddEdge(nodeA, nodeB);
            datGraph.AddEdge(nodeB, nodeE);

            // D -> A -> E
            datGraph.AddEdge(nodeD, nodeA);
            datGraph.AddEdge(nodeA, nodeE);

            // E -> C -> D -> F
            datGraph.AddEdge(nodeE, nodeC);
            datGraph.AddEdge(nodeC, nodeD);
            datGraph.AddEdge(nodeD, nodeF);

            // F -> B -> E
            datGraph.AddEdge(nodeF, nodeB);
            datGraph.AddEdge(nodeB, nodeE);


            Node nodeG = new Node("G");
            Node nodeH = new Node("H");

            Graph anotherGraph = new Graph();

            anotherGraph.AddEdge(nodeG, nodeH);

            Assert.Equal(6, datGraph.Size(nodeC));
            Assert.Equal(2, anotherGraph.Size(nodeG));
        }

        /// <summary>
        /// 2. tests the following: 
        /// GetNeighbors() returns the correct nodes given a vertice
        /// </summary>
        [Fact]
        public void CanGetNeighbors()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");

            Graph datGraph = new Graph();

            // A -> C -> F
            datGraph.AddEdge(nodeA, nodeC);
            datGraph.AddEdge(nodeC, nodeD);

            // B -> C -> F
            datGraph.AddEdge(nodeB, nodeC);
            datGraph.AddEdge(nodeC, nodeF);

            // C -> A -> B -> E
            datGraph.AddEdge(nodeC, nodeA);
            datGraph.AddEdge(nodeA, nodeB);
            datGraph.AddEdge(nodeB, nodeE);

            // D -> A -> E
            datGraph.AddEdge(nodeD, nodeA);
            datGraph.AddEdge(nodeA, nodeE);

            // E -> C -> D -> F
            datGraph.AddEdge(nodeE, nodeC);
            datGraph.AddEdge(nodeC, nodeD);
            datGraph.AddEdge(nodeD, nodeF);

            // F -> B -> E
            datGraph.AddEdge(nodeF, nodeB);
            datGraph.AddEdge(nodeB, nodeE);


            Node nodeG = new Node("G");
            Node nodeH = new Node("H");

            Graph anotherGraph = new Graph();

            anotherGraph.AddEdge(nodeG, nodeH);

            int datGraphCount = datGraph.GetNeighbors(nodeA).Count;
            int anotherGraphCount = anotherGraph.GetNeighbors(nodeG).Count;

            Assert.Equal(4, datGraphCount);
            Assert.Equal(1, anotherGraphCount);
        }

        /// <summary>
        /// 2. tests the following: 
        /// GetNeighbors() returns the correct nodes given a vertice
        /// </summary>
        [Fact]
        public void CanAddEdge()
        {
            Node nodeA = new Node("A");
            Node nodeB = new Node("B");
            Node nodeC = new Node("C");
            Node nodeD = new Node("D");
            Node nodeE = new Node("E");
            Node nodeF = new Node("F");

            Graph datGraph = new Graph();

            // A -> C -> D
            datGraph.AddEdge(nodeA, nodeC);
            datGraph.AddEdge(nodeC, nodeD);

            bool nodeAHasChildC = nodeA.Neighbors.Contains(nodeC);
            bool nodeCHasChildD = nodeC.Neighbors.Contains(nodeD);

            // B -> C -> F
            datGraph.AddEdge(nodeB, nodeC);
            datGraph.AddEdge(nodeC, nodeF);

            bool nodeBHasChildC = nodeB.Neighbors.Contains(nodeC);
            bool nodeCHasChildF = nodeC.Neighbors.Contains(nodeF);

            Assert.True(nodeAHasChildC);
            Assert.True(nodeCHasChildD);
            Assert.True(nodeBHasChildC);
            Assert.True(nodeCHasChildF);
        }
    }
}
