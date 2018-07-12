using System;
using System.Collections.Generic;

namespace Find_Islands
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 28!");


            //This should contain 4 nodes with none of them
            //connected to each other(4 islands).
            int[,] datArray1 = new int[,]
            {
                {0, 0, 0, 0 },
                {0, 0, 0, 0 },
                {0, 0, 0, 0 },
                {0, 0, 0, 0 }
            };

            Console.WriteLine(FindIslands(datArray1));

            // This should contain 6 nodes and 2 islands.
            int[,] datArray2 = new int[,]
            {
                {0, 1, 1, 0, 0, 0},
                {1, 0, 1, 1, 0, 0},
                {1, 1, 0, 0, 0, 0},
                {0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1, 0}
            };

            Console.WriteLine(FindIslands(datArray2));

            int[,] datArray3 = new int[,]
            {
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 1, 1, 1, 1, 1, 0},
            };

            Console.WriteLine(FindIslands(datArray3));

            Console.WriteLine("Thank you for watching. Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// counts the number of islands in a given adjacency matrix
        /// </summary>
        /// <param name="datArray">adjacency matrix as a 2d array</param>
        /// <returns>the number of islands from the matrix</returns>
        public static int FindIslands(int[,] datArray)
        {
            int count = 0;
            // Create a list containing the covered "nodes."
            // Because we don't actually have nodes, the index will serve
            // as our node names
            List<int> covered = new List<int>();

            // iterates vertically
            for (int i = 0; i < datArray.GetLength(0); i++)
            {
                bool hasNoOnes = true;

                // iterates horizontally
                for (int j = 0; j < datArray.GetLength(1); j++)
                {
                    if (datArray[i, j] != 0)
                    {
                        hasNoOnes = false;
                        // looks for previously found nodes in our 
                        // matrix
                        if (!covered.Contains(j))
                        {
                            covered.Add(j);
                            count++;
                        }

                        break;
                    }
                }

                // increments if a given node has no 
                // neighbors (it's an island)
                if (hasNoOnes == true)
                {
                    count++;
                }

                covered.Add(i);
            }

            return count;
        }
    }
}
