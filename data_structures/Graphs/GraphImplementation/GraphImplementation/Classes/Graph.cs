using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphImplementation.Classes
{
    public class Graph
    {
        public List<Node> Vertices { get; set; }

        public Graph()
        {
            Vertices = new List<Node>();
        }

        /// <summary>
        /// 1. Adds a new vertice to the graph
        /// </summary>
        /// <param name="parent">the parent node to attach the child to</param>
        /// <param name="child">the child node to add to the graph</param>
        /// <returns>the added child</returns>
        public Node AddEdge(Node parent, Node child)
        {
            if (!Vertices.Contains(child))
            {
                Vertices.Add(child);
            }

            if (!parent.Neighbors.Contains(child))
            {
                parent.Neighbors.Add(child);
                child.Neighbors.Add(parent);
            }

            return child;
        }

        /// <summary>
        /// 2. returns all of the nodes in the graph as a collection
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<Node> GetNodes(Node root)
        {
            return BreadthFirst(root);
        }

        /// <summary>
        /// 3. returns a collection 
        /// </summary>
        /// <param name="root">root node to get neighbors from</param>
        /// <returns>list of neighbor nodes to root</returns>
        public List<Node> GetNeighbors(Node root)
        {
            return root.Neighbors;
        }

        /// <summary>
        /// 4. returns the total number of nodes in the graph
        /// </summary>
        /// <param name="root">root node to start at</param>
        /// <returns>integer counting nodes</returns>
        public int Size(Node root)
        {
            return BreadthFirst(root).Count;
        }

        /// <summary>
        /// traverses a graph using breadth first method
        /// </summary>
        /// <param name="root">the root node to start traversal</param>
        /// <returns>a list of nodes found from traversal</returns>
        public List<Node> BreadthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();

            root.Visited = true;
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach (Node child in front.Neighbors)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
            }

            foreach (var item in order)
            {
                item.Visited = false;
            }

            return order;
        }

        /// <summary>
        /// traverses a graph with depth first (not required for assignment)
        /// (leaving commented out)
        /// </summary>
        /// <param name="root">root node to start at</param>
        /// <returns>list of nodes from the graph</returns>
        public List<Node> DepthFirst(Node root)
        {
            List<Node> visited = new List<Node>();
            return DFSUtil(root, visited);
        }

        /// <summary>
        /// helper method for DFS so that the user is not required to put in a starting value for visited nodes
        /// </summary>
        /// <param name="root"></param>
        /// <param name="visited"></param>
        /// <returns></returns>
        public List<Node> DFSUtil(Node root, List<Node> visited)
        {
            root.Visited = true;
            Console.WriteLine(root.Value);
            foreach (Node node in root.Neighbors)
            {
                if (node.Visited == false)
                {
                    DFSUtil(node, visited);
                }
            }

            foreach (Node node in visited)
            {
                node.Visited = false;
            }

            return visited;
        }
    }
}
