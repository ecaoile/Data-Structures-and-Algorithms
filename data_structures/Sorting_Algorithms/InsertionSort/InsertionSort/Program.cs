using System;

namespace InsertionSortImplement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to insertion sort implementation!\n");

            int[] datArray1 = new int[] { 6, 7, 5, 4, 3 };
            int[] datArray2 = new int[] { 33, 44, 11, 22, 100, 55 };
            Console.WriteLine("Here are your your original arrays:");
            Print(datArray1);
            Print(datArray2);

            InsertionSort(datArray1, datArray1.Length-1);
            InsertionSort(datArray2, datArray2.Length - 1);

            Console.WriteLine("\nHere are your sorted arrays:");
            Print(datArray1);
            Print(datArray2);

            Console.WriteLine("Thank you for watching. Press any key to quit.");
            Console.ReadKey();

        }

        /// <summary>
        /// sorts the elements in an integer from lowest to highest value
        /// </summary>
        /// <param name="array">integer array to sort</param>
        /// <param name="n">the last index of the array</param>
        /// <returns>the sorted array</returns>
        public static int[] InsertionSort(int[] array, int n)
        {
            if (n > 0)
            {
                InsertionSort(array, n - 1);
                int x = array[n];
                int y = n - 1;
                while (y >= 0 && array[y] > x)
                {
                    array[y + 1] = array[y];
                    y = y - 1;
                }
                array[y + 1] = x;
            }

            return array;
        }

        /// <summary>
        /// helper method to print out arrays visually in a console
        /// </summary>
        /// <param name="array">nothing - just console stuff</param>
        public static void Print(int[] array)
        {
            Console.Write("[ ");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.Write("]\n");
        }
    }
}
