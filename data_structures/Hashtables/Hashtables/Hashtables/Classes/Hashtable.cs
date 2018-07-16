using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {
        //public int HashLength { get; set; }

        public BinarySearchTree[] HashArray { get; set; }

        public Hashtable(int hashLength)
        {
            HashArray = new BinarySearchTree[hashLength];
        }

        public int ConvertChar(string word)
        {
            int value = 0;
            for (int i = 0; i < word.Length; i++)
            {
                value += word[i];
            }
            return value;
        }

        public Node Add(string key, int value)
        {
            Node datNode = new Node(key, value);
            double datDouble = Convert.ToDouble(value) * 599 % HashArray.Length;

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
            Console.WriteLine($"{datNode.Pair.Key} with a value of {datNode.Pair.Value} added to index {newIndex}");
            return datNode;
        }

        public int GetHash(string word)
        {
            int value = ConvertChar(word);
            double datDouble = Convert.ToDouble(value) * 599 / HashArray.Length;
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

        public int Find(string key)
        {
            int newIndex = GetHash(key);
            return HashArray[newIndex].Search(HashArray[newIndex].Root, key).Pair.Value;
        }

        public bool Contains(string key)
        {
            int newIndex = GetHash(key);
            Node datNode = HashArray[newIndex].Search(HashArray[newIndex].Root, key);

            if (datNode == null)
            {
                return false;
            }

            return true;
        }
    }
}
