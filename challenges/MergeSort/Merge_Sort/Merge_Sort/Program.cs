using System;

namespace Merge_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 41!");
            int[] inputArr = { 34, 19, 42, -9, 2018, 0, 2005, 77, 2099 };
            Console.WriteLine("Here's your original array:");
            PrintArray(inputArr);

            int[] outputArr = MergeSort(inputArr, 0, inputArr.Length - 1);
            Console.WriteLine("\nHere's your sorted array:");
            PrintArray(outputArr);

            Console.WriteLine("\nThank you for watching. Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// takes an array of integers and sorts them in order from smallest to largest value
        /// </summary>
        /// <param name="datArray">unsorted array of integers</param>
        /// <param name="l">leftmost index of the array to merge sort</param>
        /// <param name="r">rightmost index of the array to merge sort</param>
        /// <returns></returns>
        public static int[] MergeSort(int[] datArray, int l, int r)
        {
            if (l < r)
            {
                // the middle value between value betwee left and right indexes
                int m = (l + r) / 2;

                MergeSort(datArray, l, m);
                MergeSort(datArray, m + 1, r);

                Merge(datArray, l, m, r);
            }

            return datArray;
        }

        /// <summary>
        /// helper method that takes care of the merge functionality of merge sort
        /// </summary>
        /// <param name="inputArr">the array to merge</param>
        /// <param name="l">leftmost index</param>
        /// <param name="m">middle index</param>
        /// <param name="r">rightmost index</param>
        public static void Merge(int[] inputArr, int l, int m, int r)
        {
            // size of the subarrays to merge
            int n1 = m - l + 1;
            int n2 = r - m;

            // two temp arrays
            int[] leftTemp = new int[n1];
            int[] rightTemp = new int[n2];

            // populate arrays with values
            for (int i = 0; i < n1; i++)
                leftTemp[i] = inputArr[l + i];

            for (int j = 0; j < n2; j++)
                rightTemp[j] = inputArr[m + 1 + j];

            // merge temp arrays
            int x = 0, y = 0;

            // initial index of merged subarray
            int k = l;

            // while index of leftTemp array is less than size of the leftTemp array
            // and index of rightTemp array is less than the size of the rightTemp array
            while (x < n1 && y < n2)
            {
                if (leftTemp[x] < rightTemp[y])
                {
                    inputArr[k] = leftTemp[x];
                    x++;
                }

                else
                {
                    inputArr[k] = rightTemp[y];
                    y++;
                }

                k++;
            }

            // copy remaining elements of leftTemp to inputArr
            while (x < n1)
            {
                inputArr[k] = leftTemp[x];
                x++;
                k++;
            }

            // copy remaining elements of rightTemp to inputArr
            while (y < n2)
            {
                inputArr[k] = rightTemp[y];
                y++;
                k++;
            }
        }

        /// <summary>
        /// helper method to display arrays to the console
        /// </summary>
        /// <param name="inputArr">the array to display to the console</param>
        public static void PrintArray(int[] inputArr)
        {
            int n = inputArr.Length;
            Console.Write("[ ");
            for (int i = 0; i < n; ++i)
                Console.Write(inputArr[i] + " ");
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
