using System;

namespace Whiteboard_Challenge_03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 03!");
            // initialization of first test array
            // expected return value: 132
            int[,] firstArray2D = new int[,] { { 1, 2, 3}, { 4, 5, 6 }, { 7, 8 , 9 }, { 10, 11, 12 } };
            AdjacentProduct(firstArray2D);

            // initialization of second test array
            // expected return value: 64
            int[,] secondArray2D = new int[,] { { 1, 2, 1 }, { 2, 4, 2 }, { 3, 6, 8 }, { 7, 8, 1 } };
            AdjacentProduct(secondArray2D);

            // initialization of third test array
            // expected return value: 2
            int[,] thirdArray2D = new int[,] { { 1 }, { 2 }};
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
                Console.WriteLine($"Length of 1st dimension: {datArray.GetLength(0)}");
            Console.WriteLine($"Length of 2nd dimension: {datArray.GetLength(1)}");
            for (int i = 0; i < datArray.GetLength(0); i ++)
            {
                for (int j = 0; j < datArray.GetLength(1); j++)
                {
                    // check product of element and the item diagonal top left
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        //Console.WriteLine("Hitting diagonal top left!");
                       //Console.WriteLine($"Calculating the product of {datArray[i - 1, j - 1]} and {datArray[i, j]}.");
                        currentValue = datArray[i - 1, j - 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item diagonal top right
                    if (i - 1 >= 0 && j + 1 < datArray.GetLength(1))
                    {
                        //Console.WriteLine("Hitting diagonal top right!");
                        //Console.WriteLine($"Calculating the product of {datArray[i - 1, j + 1]} and {datArray[i, j]}.");
                        currentValue = datArray[i - 1, j + 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item diagonal bottom right
                    if (i + 1 < datArray.GetLength(0) && j + 1 < datArray.GetLength(1))
                    {
                        //Console.WriteLine("Hitting diagonal bottom right!");
                        //Console.WriteLine($"Calculating the product of {datArray[i + 1, j + 1]} and {datArray[i, j]}.");
                        currentValue = datArray[i + 1, j + 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item diagonal bottom left
                    if (i - 1 >= 0 && j + 1 < datArray.GetLength(1))
                    {
                        //Console.WriteLine("Hitting diagonal bottom left!");
                        //Console.WriteLine($"Calculating the product of {datArray[i - 1, j + 1]} and {datArray[i, j]}.");
                        currentValue = datArray[i - 1, j + 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }
                    // check product of element and the item directly above
                    if (i - 1 >= 0)
                    {
                        //Console.WriteLine($"Calculating the product of {datArray[i - 1, j]} and {datArray[i, j]}.");
                        currentValue = datArray[i - 1, j] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item directly below
                    if (i + 1 < datArray.GetLength(0))
                    {
                        //Console.WriteLine($"Calculating the product of {datArray[i + 1, j]} and {datArray[i, j]}.");
                        currentValue = datArray[i + 1, j] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item directly to the left
                    if (j - 1 >= 0)
                    {
                        //Console.WriteLine($"Calculating the product of {datArray[i, j - 1]} and {datArray[i, j]}.");
                        currentValue = datArray[i, j - 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }

                    // check product of element and the item directly to the right
                    if (j + 1 < datArray.GetLength(1))
                    {
                        //Console.WriteLine($"Calculating the product of {datArray[i, j + 1]} and {datArray[i, j]}.");
                        currentValue = datArray[i, j + 1] * datArray[i, j];
                        if (currentValue > largestValue)
                            largestValue = currentValue;
                    }
                    //Console.WriteLine($"Value at index {i},{j}: {datArray[i, j]}");

                }
            }
            Console.WriteLine($"The largest product is {largestValue}.\n");
            return largestValue;
        }
    }
}
