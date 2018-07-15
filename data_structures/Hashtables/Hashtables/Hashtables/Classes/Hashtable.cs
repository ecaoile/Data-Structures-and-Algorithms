using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {
        //public int HashLength { get; set; }

        public Dictionary<string, int>[] HashArray { get; set; }

        public Hashtable(int hashLength)
        {
            HashArray = new Dictionary<string, int>[hashLength];
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
    }
}
