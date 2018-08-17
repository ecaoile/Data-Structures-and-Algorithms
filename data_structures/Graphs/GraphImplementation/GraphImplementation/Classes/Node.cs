using System;
using System.Collections.Generic;
using System.Text;

namespace GraphImplementation.Classes
{
    public class Node
    {
        public string Value { get; set; }

        public List<Node> Neighbors { get; set; }

        public bool Visited { get; set; }

        public Node(string value)
        {
            Value = value;
            Neighbors = new List<Node>();
            Visited = false;
        }
    }
}
