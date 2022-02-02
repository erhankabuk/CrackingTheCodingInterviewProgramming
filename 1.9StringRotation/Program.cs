using System;

namespace _1._9StringRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "waterbottle";
            string s2 = "elttobrewat";
            Console.WriteLine(IsSubstring(s1, s2));
        }
        static bool IsSubstring(string s1, string s2)
        {
            int LengthOfs1 = s1.Length;

            if (LengthOfs1 != s2.Length) return false;

            int splitIndex = 0;

            for (int i = 0, j = LengthOfs1 - 1; i < LengthOfs1 / 2; i++, j--)
            {
                if (s1[i] == s2[j]) splitIndex = i - 1;
            }

            if (s1.Substring(0, splitIndex) == s2.Substring(LengthOfs1 - splitIndex, splitIndex))
            {
                for (int i = splitIndex, j = LengthOfs1 - 1 - splitIndex; i < LengthOfs1; i++, j--)
                {
                    if (s1[i] != s2[j]) return false;
                }
            }

            return true;
        }
    }
}
