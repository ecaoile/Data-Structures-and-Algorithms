using System;

namespace Quick_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 42!");

            int[] inputArr1 = {34, 19, 42, -9, 2018, 0, 2005, 77, 2099};
            Console.WriteLine("\nHere is your initial array:");
            PrintArray(inputArr1, inputArr1.Length);

            int[] outputArr1 = QuickSort(inputArr1, 0, inputArr1.Length - 1);
            Console.WriteLine("\nHere is your sorted array:");
            PrintArray(outputArr1, outputArr1.Length);

            Console.WriteLine("\nThank you for watching. Press any key to exit.");
            Console.ReadKey();
        }

        public static int[] QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1); // before pi
                QuickSort(arr, pi + 1, high); // after pi
            }

            return arr;
        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void PrintArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
