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
            // set initial min value to 0 (first array element) and 
            // max to array.Length - 1 (last array element)
            int currentSecMin = 0, currentSecMax = array.Length - 1;
            while (currentSecMin <= currentSecMax)
            {
                // get a middle by adding the min and max and dividing by 2
                int currentSecMid = (currentSecMin + currentSecMax) / 2;
                
                // handle an equal value found in the current section middle
                if (key == array[currentSecMid])
                {
                    Console.WriteLine($"Match with key of {key} find at index {currentSecMid}.");
                    return currentSecMid;
                }

                // if key is lower than the middle array element,
                // move section max value to where the middle used to be
                if (key < array[currentSecMid])
                    currentSecMax = currentSecMid - 1;

                // else, move section min value to where middle used to be
                else
                    currentSecMin = currentSecMid + 1;
            }

            // return  -1 if there is no match after traversing through the array
            Console.WriteLine($"No match with key {key} found! Returning -1");
            return -1;
        }
    }
}
