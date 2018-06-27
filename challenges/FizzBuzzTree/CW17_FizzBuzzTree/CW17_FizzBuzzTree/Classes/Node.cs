using System;
using System.Collections.Generic;
using System.Text;

namespace CW17_FizzBuzzTree.Classes
{
    /// <summary>
    /// consists of two properties types: a value and next
    /// </summary>
    public class Node
    {
        // we're holding string values in these particular nodes just for this whiteboard challenge
        public string Value { get; set; }

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }

        /// <summary>
        /// constructor for node, needs to have a string root to be created
        /// </summary>
        /// <param name="value">string value for the node to create</param>
        public Node(string value)
        {
            Value = value;
        }
    }
}
