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

        public static int[] RadixSort(int[] arr, int n)
        {
            int m = GetMax(arr, n);

            for (int exp = 1; m / exp > 0; exp *= 10)
                CountSort(arr, n, exp);

            return arr;
        }

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

        public static void CountSort(int[] arr, int n, int exp)
        {
            int[] output = new int[n];
            int i;
            int[] count = new int[10];

            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;

            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }

        public static void PrintArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
