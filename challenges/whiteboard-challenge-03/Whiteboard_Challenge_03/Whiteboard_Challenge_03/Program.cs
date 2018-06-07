using System;

namespace Whiteboard_Challenge_03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 03!\n");
            // initialization of first test array
            // calling method with first test array as input
            // expected return value: 210
            int[,] firstArray2D = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
            Console.WriteLine("1st Array");
            AdjacentProduct(firstArray2D);

            // initialization of second test array
            // calling method with second test array as input
            // expected return value: 64
            int[,] secondArray2D = new int[,] { { 1, 2, 1 }, { 2, 4, 2 }, { 3, 6, 8 }, { 7, 8, 1 } };
            Console.WriteLine("2nd Array");
            AdjacentProduct(secondArray2D);

            // initialization of third test array
            // calling method with third test array as input
            // expected return value: 2
            int[,] thirdArray2D = new int[,] { { 1 }, { 2 }};
            Console.WriteLine("3rd Array");
            AdjacentProduct(thirdArray2D);

            Console.WriteLine("Thank you for playing! Press any button to exit.");
            Console.ReadLine();
        }
        /// <summary>
        /// gets the product of all adjacent elements in the array and finds the largest product
        /// </summary>
        /// <param name="datArray">a 2 dimensional integer array</param>
        /// <returns>a product containing the largest value of adjacent elements</returns>
        public static int AdjacentProduct(int[,] datArray)
        {
            int largestValue = 0;
            int currentValue = 0;
            Console.WriteLine("Here's what your array looks like:");
            for (int i = 0; i < datArray.GetLength(0); i++)
            {
                for (int j = 0; j < datArray.GetLength(1); j++)
                {
                    if (datArray[i, j] < 10)
                        Console.Write($"  {datArray[i, j]}    ");
                    else
                        Console.Write($" {datArray[i, j]}    ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nLength of 1st dimension: {datArray.GetLength(0)}");
            Console.WriteLine($"Length of 2nd dimension: {datArray.GetLength(1)}");
            for (int i = 0; i < datArray.GetLength(0); i ++)
            {
                for (int j = 0; j < datArray.GetLength(1); j++)
                {
                    // check product of element and the item diagonal top left
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        currentValue = datArray[i - 1, j - 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item diagonal top right
                    if (i - 1 >= 0 && j + 1 < datArray.GetLength(1))
                    {
                        currentValue = datArray[i - 1, j + 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item diagonal bottom right
                    if (i + 1 < datArray.GetLength(0) && j + 1 < datArray.GetLength(1))
                    {
                        currentValue = datArray[i + 1, j + 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item diagonal bottom left
                    if (i - 1 >= 0 && j + 1 < datArray.GetLength(1))
                    {
                        currentValue = datArray[i - 1, j + 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item directly above
                    if (i - 1 >= 0)
                    {
                        currentValue = datArray[i - 1, j] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item directly below
                    if (i + 1 < datArray.GetLength(0))
                    {
                        currentValue = datArray[i + 1, j] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item directly to the left
                    if (j - 1 >= 0)
                    {
                        currentValue = datArray[i, j - 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item directly to the right
                    if (j + 1 < datArray.GetLength(1))
                    {
                        currentValue = datArray[i, j + 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }
                }
            }
            Console.WriteLine($"The largest product is {largestValue}.\n");
            return largestValue;
        }
    }
}
