using System;
using System.Collections.Generic;
using System.Text;

namespace BT_and_BST.Classes
{
    /// <summary>
    /// consists of two properties types: a value and next
    /// </summary>
    public class Node
    {
        public double Value { get; set; }

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }

        /// <summary>
        /// constructor for node, needs to have an int to be created
        /// </summary>
        /// <param name="value">int value for the node to create</param>
        public Node(double value)
        {
            Value = value;
        }
    }
}
