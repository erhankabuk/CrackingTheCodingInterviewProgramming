using System;

namespace _1._6StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "aabcccccaaa";
            Console.WriteLine(CompressInput(input));
        }

        static string CompressInput(string input)
        {
            //First Solution
            /*
            int count = 0;
            int split = 0;
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {

                if (i + 1 == input.Length)
                {
                    count++;
                    output = output.Insert(split, input[i].ToString());
                    output = output.Insert(split + 1, count.ToString());

                }
                else if (input[i] == input[i + 1])
                {
                    count++;
                }
                else
                {
                    count++;
                    output = output.Insert(split, input[i].ToString());
                    output = output.Insert(split + 1, count.ToString());
                    count = 0;
                    split += 2;
                }
            }

            if (output.Length >= input.Length) return input;

            return output;

            */


            // Second Solution O(n + k^2)

            string compressedString = "";
            int countConsecutive = 0;
            for (int i = 0; i < input.Length; i++)
            {
                countConsecutive++;
                if (i + 1 >= input.Length || input[i] != input[i + 1])
                {
                    compressedString += "" + input[i] + countConsecutive;
                    countConsecutive = 0;
                }
            }
            return compressedString.Length < input.Length ? compressedString : input;
        }
    }
}
