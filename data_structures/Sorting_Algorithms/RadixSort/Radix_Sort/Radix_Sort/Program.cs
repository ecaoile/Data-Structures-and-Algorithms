using System;

namespace Radix_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 43!");
            int[] inputArr = { 34, 19, 42, 2018, 0, 2005, 77, 2099 };
            Console.WriteLine("\nHere is your initial array:");
            PrintArray(inputArr, inputArr.Length);

            int[] outputArr = RadixSort(inputArr, inputArr.Length);
            Console.WriteLine("\nHere is your sorted array:");
            PrintArray(outputArr, outputArr.Length);

            Console.WriteLine("\nThank you for watching. Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// sorting algorithm that takes in an array of integers and sorts them
        /// Values must be positive.
        /// </summary>
        /// <param name="arr">an array of integers</param>
        /// <param name="n">number of elements in the array</param>
        /// <returns>the sorted array</returns>
        public static int[] RadixSort(int[] arr, int n)
        {
            // get the maximum value in the int array
            int m = GetMax(arr, n);
            // do counting sort for every digit. Instead of passing
            // a digit number, exp is passed. exp is 10^i with i 
            // (current digit number) starting at 1
            for (int exp = 1; m / exp > 0; exp *= 10)
                CountSort(arr, n, exp);

            return arr;
        }

        /// <summary>
        /// helper method that gets the max value of an integer array
        /// </summary>
        /// <param name="arr">an array of integers</param>
        /// <param name="n">number of elements in the array</param>
        /// <returns>the max value in the int array</returns>
        public static int GetMax(int[] arr, int n)
        {
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }

        /// <summary>
        /// performs a counting sort of the int array passed into RadixSort according
        /// to the digit represented by exp
        /// </summary>
        /// <param name="arr">an int array</param>
        /// <param name="n">number of elements to look at</param>
        /// <param name="exp">the exponent that increases by 10 to look at each digit of each array value</param>
        public static void CountSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];

            // store count of occurrences in count array
            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            // change count[i] so that count[i] now contains actual position 
            // of this digit in output[]
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // build the output array
            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            // copy the output array to the int array so that it now contains
            // sorted numbers according to current digit
            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }

        /// <summary>
        /// helper method to print out an array
        /// </summary>
        /// <param name="arr">the array to display</param>
        /// <param name="n">the number of elements in the array</param>
        public static void PrintArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
