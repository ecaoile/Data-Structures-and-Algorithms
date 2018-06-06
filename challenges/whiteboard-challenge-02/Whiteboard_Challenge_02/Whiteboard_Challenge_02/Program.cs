using System;

namespace Whiteboard_Challenge_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializing first array used for demonstration purposes
            int[] firstArr = new int[] { 1, 2, 3 };
            
            // invoke function on first array with key - expected match at index 1
            BinarySearch(firstArr, 2);
            // invoke function on first array with different key - no match expected -> return -1
            BinarySearch(firstArr, 5);

            // initializing second array used for demonstration purposes
            int[] secondArr = new int[] { 1, 2, 3, 4, 5, 6 };

            // invoke function on second array with key - expected match at index 3
            BinarySearch(secondArr, 4);
            // invoke function on second array with key - no match expected -> return -1
            BinarySearch(secondArr, 555);

            // closing message before user exits the program
            Console.WriteLine("Thank you for playing! Press any button to quit.");
            Console.ReadLine();
        }

        // BinarySearch function:
        // input: an integer array and a key integer value
        // output: the index at which the key value appears if present, else -1 for no match
        public static int BinarySearch(int[] array, int key)
        {
            Console.WriteLine("\nRunning BinarySearch function...");
            int currentSecMin = 0, currentSecMax = array.Length - 1;
            while (currentSecMin <= currentSecMax)
            {
                int currentSecMid = (currentSecMin + currentSecMax) / 2;
                if (key == array[currentSecMid])
                {
                    Console.WriteLine($"Match with key of {key} find at index {currentSecMid}.");
                    return currentSecMid;
                }

                if (key < array[currentSecMid])
                    currentSecMax = currentSecMid - 1;

                else
                    currentSecMin = currentSecMid + 1;
            }

            Console.WriteLine($"No match with key {key} found! Returning -1");
            return -1;
        }
    }
}
