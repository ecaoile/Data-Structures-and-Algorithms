using System;
using System.Collections.Generic;
using System.Text;

namespace Left_Join.Classes
{
    public class HashMap
    {
        public LinkList[] HashArray { get; set; }

        public HashMap(int hashLength)
        {
            HashArray = new LinkList[hashLength];
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
        public Node Add(string key, string value)
        {
            Node datNode = new Node(key, value);
            int newIndex = GetHash(key);

            if (HashArray[newIndex] == null)
            {
                HashArray[newIndex] = new LinkList(datNode);
                //Console.WriteLine($"Added [{datNode.Key}, {datNode.Values[0]}]");
            }

            else
            {
                Console.WriteLine("Collision detected!");
                HashArray[newIndex].AddLast(datNode);
            }

            //Console.WriteLine($"[{datNode.Key}, {datNode.Pair.Value}] added to index {newIndex}");
            return datNode;
        }

        /// <summary>
        /// custom add that points to a method that adds a value to an existing key
        /// </summary>
        /// <param name="key">key in key value pair</param>
        /// <param name="value">value in key value pair</param>
        public void AddJoin(string key, string value)
        {
            Node datNode = new Node(key, value);
            int newIndex = GetHash(key);

            if (HashArray[newIndex] != null)
            {
                HashArray[newIndex].AddValueToKey(datNode);
            }

            //Console.WriteLine($"[{datNode.Key}, {datNode.Pair.Value}] added to index {newIndex}");
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
        public List<string> Find(string key)
        {
            int newIndex = GetHash(key);
            if (HashArray[newIndex] == null)
                return null;

            return HashArray[newIndex].Find(key).Values;
        }

        /// <summary>
        /// returns a boolean determining whether the hashtable contains a given key
        /// </summary>
        /// <param name="key">the string to search for</param>
        /// <returns>true if a match is found, else false</returns>
        public bool Contains(string key)
        {
            List<string> demValues = Find(key);

            if (demValues == null)
            {
                return false;
            }

            return true;
        }
    }
}
