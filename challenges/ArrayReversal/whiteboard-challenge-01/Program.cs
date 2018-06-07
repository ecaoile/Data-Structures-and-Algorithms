using System;

namespace whiteboard_challenge_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializing an array for demonstration purposes:
            int[] newArr = new int[5] { 1, 2, 3, 4, 5 };

            // displaying the array to the console with a for loop
            Console.Write("Original array: ");
            foreach (var num in newArr)
                Console.Write($"{num} ");

            // invoking the function on the given array to create a new array
            int[] revArr = ArrayReverse(newArr);

            // displaying the reversed array
            Console.Write("\nReversed array: ");
            foreach (var num in revArr)
                Console.Write($"{num} ");

            // closing message before user exits the app
            Console.WriteLine("\nThank you for playing. Press any button to exit.");
            Console.ReadLine();
        }

        // reverse function: 
        // input: takes in an array of integers
        // output: array with values in reverse order
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
