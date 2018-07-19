using System;
using System.Collections.Generic;
using Left_Join.Classes;

namespace Left_Join
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 34!");

            HashMap datHM1 = new HashMap(1024);
            datHM1.Add("fond", "enamored");
            datHM1.Add("wrath", "angered");
            datHM1.Add("diligent", "employed");
            datHM1.Add("outfit", "garb");
            datHM1.Add("guide", "usher");

            HashMap datHM2 = new HashMap(1024);
            datHM2.Add("fond", "averse");
            datHM2.Add("wrath", "delight");
            datHM2.Add("diligent", "idle");
            datHM2.Add("guide", "follow");
            datHM2.Add("flow", "jam");

            List<List<string>> datListOfLists = LeftJoin(datHM1, datHM2);
            foreach (var list in datListOfLists)
            {
                Print(list);
            }
            Console.WriteLine("\nThank you for watching! Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// returns a list of lists emulating a left join between two hashmaps
        /// </summary>
        /// <param name="datHM1">the left table represented by a hashmap</param>
        /// <param name="datHM2">the right table represented by the hash map</param>
        /// <returns>the resulting table as a list of string lists after performing a left join</returns>
        public static List<List<string>> LeftJoin(HashMap datHM1, HashMap datHM2)
        {
            // making an assumption that we're allowed to know the keys of a hashmap
            List<string> hMap1Keys = new List<string> { "fond", "wrath", "diligent", "outfit", "guide" };
            List<string> hMap2Keys = new List<string> { "fond", "wrath", "diligent", "guide", "flow" };
            List<string> hMap2Values = new List<string>();

            foreach (var key in hMap2Keys)
            {
                hMap2Values.AddRange(datHM2.Find(key));
            }

            for (int i = 0; i < hMap2Keys.Count; i++)
            {
                datHM1.AddJoin(hMap2Keys[i], hMap2Values[i]);
            }
            
            foreach (var key in hMap1Keys)
            {
                // emulating the .contains method because 
                // Collin got jealous that I was using it
                bool isHMap1Key = false;
                foreach (var hMap2Key in hMap2Keys)
                {
                    if (hMap2Key == key)
                    {
                        isHMap1Key = true;
                        break;
                    }
                }

                if (isHMap1Key == false)
                    datHM1.AddJoin(key, null);
            }

            List<List<string>> returnLists = new List<List<string>>();

            foreach (var key in hMap1Keys)
            {
                List<string> tempList = new List<string> { key };
                tempList.AddRange(datHM1.Find(key));
                returnLists.Add(tempList);
            }
           
            return returnLists;
        }

        /// <summary>
        /// helper method to print out a list of integers to the console
        /// </summary>
        /// <param name="datIntList">the list of integers to print out</param>
        public static void Print(List<string> datIntList)
        {
            Console.Write("[ ");
            foreach (string word in datIntList)
            {
                if (word == null)
                {
                    Console.Write($"NULL");
                }

                Console.Write($"{word} ");
            }
            Console.Write("]\n");
        }
    }
}
