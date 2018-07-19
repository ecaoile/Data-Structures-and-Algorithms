using System;
using System.Collections.Generic;
using System.Text;

namespace Left_Join.Classes
{
    /// <summary>
    /// consists of two properties types: a value and next
    /// </summary>
    public class Node
    {
        //public KeyValuePair<string,int> Pair { get; set; }
        // Every node is going to be a type of node

        public string Key { get; set; }

        public List<string> Values { get; set; }

        public Node Next { get; set; }

        public int Count { get; set; }

        /// <summary>
        /// constructor for node, needs to have an int to be created
        /// </summary>
        /// <param name="value">int value for the node to create</param>
        public Node(string key, string value)
        {
            Key = key;
            Values = new List<string> { value };
            Count = 1;
        }
    }
}
