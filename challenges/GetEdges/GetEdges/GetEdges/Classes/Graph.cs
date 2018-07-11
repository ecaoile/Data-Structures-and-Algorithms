using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetEdges.Classes
{
    public class Graph
    {
        public List<Node> AllNodes { get; set; }

        public Graph()
        {
            AllNodes = new List<Node>();
        }

        /// <summary>
        /// 1. Adds a new vertice to the graph
        /// </summary>
        public void AddEdge(Node parent, Node child, decimal cost)
        {
            if (!parent.Children.Keys.Contains(child))
            {
                parent.Children.Add(child, cost);
                child.Children.Add(parent, cost);
            }

            if (!AllNodes.Contains(parent))
                AllNodes.Add(parent);

            if (!AllNodes.Contains(child))
                AllNodes.Add(child);
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
            var allNodes = GetNodes(root);

            // initializing list with root's children
            List<Node> demNeighbors = new List<Node>(root.Children.Keys);

            // adding the "parents"
            foreach (var item in allNodes)
            {
                if (item.Children.Keys.Contains(root) && !demNeighbors.Contains(item))
                {
                    demNeighbors.Add(item);
                }
            }

            return demNeighbors;
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

                foreach (Node child in front.Children.Keys)
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
        /// determines whether traversal through a list of nodes is possible within a graph
        /// and returns the weight of all traversals
        /// </summary>
        /// <param name="nodes">list of nodes in a graph to traverse</param>
        /// <returns>a key value pair determining whether the trip is possible
        /// and how much it costs</returns>
        public KeyValuePair<bool,decimal> GetEdges(List<Node> nodes)
        {
            decimal total = 0;
            if (nodes.Count <= 1)
            {
                Console.WriteLine("You don't have anywhere else to go!");
                return new KeyValuePair<bool, decimal>(false, 0);
            }

            for(int i = 0; i < nodes.Count - 1; i++)
            {
                if (!GetNeighbors(nodes[i]).Contains(nodes[i+1]))
                {
                    Console.WriteLine("Flight does not connect!");
                    return new KeyValuePair<bool, decimal>(false, 0);
                }

                foreach (KeyValuePair<Node, decimal> pair in nodes[i].Children)
                {
                    if (pair.Key.Name == nodes[i+1].Name)
                    {
                        Console.WriteLine($"Adding value of {pair.Value} going from {nodes[i].Name} to {nodes[i+1].Name}");
                        total += pair.Value;
                    }
                }
            }
            Console.WriteLine($"Your total is {total}");
            return new KeyValuePair<bool, decimal>(true, total);
        }
    }
}
