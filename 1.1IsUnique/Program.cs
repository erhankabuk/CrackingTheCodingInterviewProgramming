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
            Console.WriteLine(IsUnique(s1));
            Console.WriteLine(IsUnique(s2));

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
