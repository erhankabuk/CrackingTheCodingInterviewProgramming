using System;

namespace _1._1IsUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hints: hashtable, vector O(N log N)

            string s1 = "abcd10jk";
            string s2 = "hutg9mnd!nk9";
            string s3 = "Bp1wSTTqyITjR8Tf7QiqbNNRYpW8ErANe7l13N1pQRdlsYBswgI5ufUkE8C7t7VWm631LhJ2BMIV9sxzxJhjrDpe1UdxuzoSwJl3asR1sW9vf9hkdl7mXo7H";
            string s4 = " !#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
            Console.WriteLine(IsUnique(s1));
            Console.WriteLine(IsUnique(s2));
            Console.WriteLine(IsUnique(s3));
            Console.WriteLine(IsUnique(s4));

            Console.ReadKey();
        }
        /* Bad Solution
        static bool IsUnique(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf(s.Substring(i, 1)) == s.Length - (s.LastIndexOf(s.Substring(i, 1)))) return true;
            }
            return false;
        }
         */


        //Good Solution
        // Let us take string become with 128 chars.
        static bool IsUnique(string s)
        {
            //if s.Length > 128 it means there are many of some chars 
            if (s.Length > 128) return false;

            //Boolean array is empty
            bool[] charsOfString = new bool[128];

            //Check all chars in s
            for (int i = 0; i < s.Length; i++)
            {
                //Take ASCII number of each char in s[]
                int val = s[i];
                //if this char checked before index of that char in bool array assigned as true when first met.
                if (charsOfString[val]) return false;
                //if char didnt existed before make that index true in s
                charsOfString[val] = true;
            }
            //if all chars are unique return true.
            return true;
        }


    }
}
