using System;
using System.Collections.Generic;

namespace _1._3URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Mr John Smith     ";
            int lengthOfInput = 13;
            char[] inputArr = input.ToCharArray();

            //First Solution
            Console.WriteLine(ReplaceAllSpaces(input, lengthOfInput));

            //Second Solution
            Console.WriteLine(ReplaceAllSpaces(inputArr, lengthOfInput));

            Console.ReadKey();
        }

        //First Solution

        static string ReplaceAllSpaces(string input, int lenghtOfInput)
        {
            return input.Substring(0, lenghtOfInput).Replace(" ", "%20");
        }


        //Second Solution

        static char[] ReplaceAllSpaces(char[] input, int lengthOfInput)
        {
            //Count how many spaces in string.
            int count = 0;
            for (int i = 0; i < lengthOfInput; i++)
            {
                if (input[i] == 32) count++;
            }

            //Add new length after replace " " with "%20";
            int newLengthOfString = lengthOfInput + count * 2;

            // If needs trim input as lengthOfInput size
            if (lengthOfInput < input.Length)
                // '\0' => escape sequence null
                input[lengthOfInput] = '\0';

            //Check all spaces in input from bacwards
            for (int i = lengthOfInput - 1; i >= 0; i--)
            {
                //if (input[i] == 32)
                //if there is a space than change with %20 in newLengthOfString
                if (input[i] == ' ')
                {
                    input[newLengthOfString - 1] = '0';
                    input[newLengthOfString - 2] = '2';
                    input[newLengthOfString - 3] = '%';

                    newLengthOfString = newLengthOfString - 3;
                }
                //if there is no space update current index value in end of input as newLengthOfString. This is like extended size of char[] input.
                else
                {
                    input[newLengthOfString - 1] = input[i];
                    newLengthOfString--;
                }

            }

            return input;
        }

    }
}
