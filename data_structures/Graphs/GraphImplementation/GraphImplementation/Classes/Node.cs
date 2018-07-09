using System;
using System.Collections.Generic;
using System.Text;

namespace GraphImplementation.Classes
{
    public class Node
    {
        public string Value { get; set; }

        public List<Node> Children { get; set; }

        public bool Visited { get; set; }

        public Node(string value)
        {
            Value = value;
            Children = new List<Node>();
            Visited = false;
        }
    }
}
