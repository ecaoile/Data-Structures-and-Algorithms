using System;
using System.Collections.Generic;
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
        /// <param name="parent"></param>
        /// <param name="child"></param>
        /// <returns></returns>
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
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public List<Node> GetNeighbors(Node root)
        {
            var allNodes = GetNodes(root);

            // initializing list with root's children
            List<Node> demNeighbors = new List<Node>(root.Children);

            // adding the "parents"
            foreach (var item in allNodes)
            {
                if (item.Children.Contains(root))
                {
                    demNeighbors.Add(item);
                }
            }

            return demNeighbors;
        }

        public int GetSize(Node root)
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

            order.RemoveAt(order.Count - 1);

            foreach (var item in order)
            {
                item.Visited = false;
            }

            return order;
        }

        //public List<Node> DepthFirst(Node root)
        //{
        //    List<Node> order = new List<Node>();
        //    Stack<Node> depth = new Stack<Node>();
        //    depth.Push(root);

        //    while (depth.TryPeek(out root))
        //    {
        //        Node top = depth.Pop();
        //        order.Add(top);

        //        foreach (Node child in top.Children)
        //        {
        //            if (!child.Visited)
        //            {
        //                child.Visited = true;
        //                depth.Push(child);
        //            }
        //        }
        //    }
        //    return order;
        //}
    }
}
