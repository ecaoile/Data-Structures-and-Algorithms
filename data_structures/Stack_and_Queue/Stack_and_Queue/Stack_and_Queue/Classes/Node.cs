using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    /// <summary>
    /// consists of two properties types: a value and next
    /// </summary>
    public class Node
    {
        public int Value { get; set; }
        // Every node is going to be a type of node
        // think of those Russian dolls...
        public Node Next { get; set; }

        /// <summary>
        /// constructor for node, needs to have an int to be created
        /// </summary>
        /// <param name="value">int value for the node to create</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
