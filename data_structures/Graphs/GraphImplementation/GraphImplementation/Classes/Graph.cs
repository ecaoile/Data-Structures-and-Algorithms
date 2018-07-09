using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphImplementation.Classes
{
    public class Graph
    {
        public Graph()
        {

        }

        /// <summary>
        /// 1. Adds a new vertice to the graph
        /// </summary>
        /// <param name="parent">the parent node to attach the child to</param>
        /// <param name="child">the child node to add to the graph</param>
        /// <returns>the added child</returns>
        public Node AddEdge(Node parent, Node child)
        {
            parent.Children.Add(child);
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
            var allNodes = GetNodes(root);

            // initializing list with root's children
            List<Node> demNeighbors = new List<Node>(root.Children);

            // adding the "parents"
            foreach (var item in allNodes)
            {
                if (item.Children.Contains(root) && !demNeighbors.Contains(item))
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
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach (Node child in front.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
            }

            order = order.Distinct().ToList();

            foreach (var item in order)
            {
                item.Visited = false;
            }

            return order;
        }

        /// <summary>
        /// traverses a graph with depth first (not required for assignment)
        /// </summary>
        /// <param name="root">root node to start at</param>
        /// <returns>list of nodes from the graph</returns>
        public List<Node> DepthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Stack<Node> depth = new Stack<Node>();
            depth.Push(root);

            while (depth.TryPeek(out root))
            {
                Node top = depth.Peek();

                foreach (Node child in top.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        depth.Push(child);
                    }
                    else
                    {
                        order.Add(top);
                        depth.Pop();
                    }
                }
            }
            return order;
        }
    }
}
