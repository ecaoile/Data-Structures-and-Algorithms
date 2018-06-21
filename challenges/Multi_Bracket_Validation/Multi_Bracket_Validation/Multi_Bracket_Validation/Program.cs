using System;
using System.Collections.Generic;
using System.Linq;

namespace Multi_Bracket_Validation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Whiteboard Challenge 13!");
            
            // should return true
            Console.WriteLine(MultiBracketValidation("{}"));
            Console.WriteLine();

            // should return true
            Console.WriteLine(MultiBracketValidation("{}(){}"));
            Console.WriteLine();

            // should return true
            Console.WriteLine(MultiBracketValidation("()[[Extra Characters]]"));
            Console.WriteLine();

            // should return true
            Console.WriteLine(MultiBracketValidation("(){}[[]]"));
            Console.WriteLine();

            // should return true
            Console.WriteLine(MultiBracketValidation("{}{Code}[Fellows](())"));
            Console.WriteLine();

            // should return false
            Console.WriteLine(MultiBracketValidation("[({}]"));
            Console.WriteLine();

            // should return false
            Console.WriteLine(MultiBracketValidation("(]("));
            Console.WriteLine();

            // should return false
            Console.WriteLine(MultiBracketValidation("({)}"));
            Console.WriteLine();

            // should return false
            Console.WriteLine(MultiBracketValidation("{})("));
            Console.WriteLine();
            Console.WriteLine("Thank you for playing. Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// determines whether a string is valid for 3 different kinds of brackets: {}, (), and [].
        /// </summary>
        /// <param name="input">the string to validate</param>
        /// <returns>true or false depending on whether string is valid</returns>
        public static bool MultiBracketValidation(string input)
        {
            Console.Write($"Input: {input}, result: ");
            List<char> demBrackets = new List<char>();
            string validBrackets = "(){}[]";
            string leftBrackets = "({[";
            string rightBrackets = ")}]";

            // creates a list of only brackets
            foreach (char c in input)
            {
                if (validBrackets.Contains(c.ToString()))
                    demBrackets.Add(c);
            }

            // handles edge cases of odd number of brackets, a right bracket at the beginning, or no brackets
            if (demBrackets.Count % 2 != 0 || rightBrackets.Contains(demBrackets[0].ToString()) || demBrackets.Count == 0)
                return false;

            // create separate list for left and right brackets
            List<char> inputLeftBrackets = new List<char>();
            List<char> inputRightBrackets = new List<char>();

            // places brackets in their appropriate lists, ignoring valid neighboring
            // pairs (i.e.: (), {}, []) right next to each other.
            for (int i = 0; i < demBrackets.Count; i += 2)
            {
                // edge case for a right bracket right before a left one
                if (rightBrackets.Contains(demBrackets[i].ToString()) && leftBrackets.Contains(demBrackets[i + 1].ToString()))
                    return false;

                if (leftBrackets.Contains(demBrackets[i].ToString()) && rightBrackets.Contains(demBrackets[i+1].ToString()))
                {
                    if (demBrackets[i] == '{' && demBrackets[i + 1] != '}' && demBrackets[i] == '[' 
                        && demBrackets[i + 1] != ']' && demBrackets[i] == '(' && demBrackets[i + 1] != ')')
                    {
                        inputLeftBrackets.Add(demBrackets[i]);
                        inputRightBrackets.Add(demBrackets[i + 1]);
                    }
                }

                if (leftBrackets.Contains(demBrackets[i].ToString()) && leftBrackets.Contains(demBrackets[i+1].ToString()))
                {
                    inputLeftBrackets.Add(demBrackets[i]);
                    inputLeftBrackets.Add(demBrackets[i+1]);
                }

                if (rightBrackets.Contains(demBrackets[i].ToString()) && rightBrackets.Contains(demBrackets[i+1].ToString()))
                {
                    inputRightBrackets.Add(demBrackets[i]);
                    inputRightBrackets.Add(demBrackets[i + 1]);
                }
            }

            // checks the remaining lists to ensure they are mirrors of each other
            for (int i = 0, j = inputRightBrackets.Count - 1; i < inputLeftBrackets.Count && j >=0; i++, j--)
            {
                if (inputLeftBrackets[i] == '{' && inputRightBrackets[j] != '}' || inputLeftBrackets[i] == '['
                && inputRightBrackets[j] != ']' || inputLeftBrackets[i] == '(' && inputRightBrackets[j] != ')')
                    return false;
            }
            return true;
        }
    }
}
