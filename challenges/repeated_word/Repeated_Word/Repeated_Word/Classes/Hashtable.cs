using System;
using System.Collections.Generic;
using System.Text;

namespace Repeated_Word.Classes
{
    public class Hashtable
    {
        //public int HashLength { get; set; }

        public BinarySearchTree[] HashArray { get; set; }

        public Hashtable(int hashLength)
        {
            HashArray = new BinarySearchTree[hashLength];
        }

        /// <summary>
        /// converts a string to an integer based on ASCII values
        /// </summary>
        /// <param name="word">the string to convert</param>
        /// <returns>an integer representing 
        /// the total of ASCII values of a given word</returns>
        public int ConvertChar(string word)
        {
            int value = 0;
            for (int i = 0; i < word.Length; i++)
            {
                value += word[i];
            }
            return value;
        }

        /// <summary>
        /// adds a node to a hashtable
        /// </summary>
        /// <param name="key">the key of the key value pair in a new node</param>
        /// <param name="value">the value of the key value pair in a new node</param>
        /// <returns>the added node</returns>
        public Node Add(string key, int value)
        {
            Node datNode = new Node(key, value);
            int newIndex = GetHash(key);

            if (HashArray[newIndex] == null)
            {
                HashArray[newIndex] = new BinarySearchTree(datNode);
            }

            else
            {
                Console.WriteLine("Collision detected!");
                HashArray[newIndex].Add(HashArray[newIndex].Root, key, value);
            }

            Console.WriteLine($"[{datNode.Pair.Key}, {datNode.Pair.Value}] added to index {newIndex}");
            return datNode;
        }

        /// <summary>
        /// generates an index within the hashtable 
        /// based on the ASCII value of a string
        /// </summary>
        /// <param name="word">the word to derive a hash value from</param>
        /// <returns>a hash value that serves as an 
        /// index within the hash table</returns>
        public int GetHash(string word)
        {
            int value = ConvertChar(word);
            double datDouble = Convert.ToDouble(value) * 1223 / HashArray.Length;
            while (datDouble > HashArray.Length)
            {
                if (datDouble > HashArray.Length)
                {
                    datDouble = datDouble % HashArray.Length;
                }
            }
            int newIndex = Convert.ToInt32(datDouble);
            return newIndex;
        }

        /// <summary>
        /// finds 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Find(string key)
        {
            int newIndex = GetHash(key);
            if (HashArray[newIndex] == null)
                return 0;
            return HashArray[newIndex].Search(HashArray[newIndex].Root, key);
        }

        /// <summary>
        /// returns a boolean determining whether the hashtable contains a given key
        /// </summary>
        /// <param name="key">the string to search for</param>
        /// <returns>true if a match is found, else false</returns>
        public bool Contains(string key)
        {
            int datValue = Find(key);

            if (datValue == 0)
            {
                return false;
            }

            return true;
        }
    }
}
