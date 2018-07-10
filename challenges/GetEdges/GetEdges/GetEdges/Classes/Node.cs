using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdges.Classes
{
    public class Node
    {
        public string Name { get; set; }

        public Dictionary<Node, decimal> Children { get; set; }

        public bool Visited { get; set; }

        public Node(string value)
        {
            Name = value;
            Children = new Dictionary<Node, decimal>();
            Visited = false;
        }
    }
}
