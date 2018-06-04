using System;

namespace whiteboard_challenge_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArr = new int[5] { 1, 2, 3, 4, 5 };

            Console.Write("Original array: ");
            foreach (var num in newArr)
                Console.Write($"{num} ");

            int[] revArr = ArrayReverse(newArr);

            Console.Write("\nReversed array: ");
            foreach (var num in revArr)
                Console.Write($"{num} ");

            Console.WriteLine("\nThank you for playing. Press any button to exit.");
            Console.ReadLine();
        }

        public static int[] ArrayReverse(int[] array)
        {
            int[] revArray = new int[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                revArray[i] = array[j];
            }
            return revArray;
        }
    }
}
