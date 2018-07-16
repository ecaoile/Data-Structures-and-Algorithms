using System;
using System.Collections.Generic;
using System.Text;

namespace Repeated_Word.Classes
{
    /// <summary>
    /// consists of two properties types: a value and next
    /// </summary>
    public class Node
    {
        public KeyValuePair<string,int> Pair { get; set; }
        // Every node is going to be a type of node

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }

        public int Count { get; set; }

        /// <summary>
        /// constructor for node, needs to have an int to be created
        /// </summary>
        /// <param name="value">int value for the node to create</param>
        public Node(string word, int num)
        {
            Pair = new KeyValuePair<string, int>(word, num);
            Count = 1;
        }
    }
}
