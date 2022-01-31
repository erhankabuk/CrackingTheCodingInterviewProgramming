using System;

namespace _1._5OneWay
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "pale";
            string s2 = "ple";
            string s3 = "bale";
            string s4 = "bake";
            string s5 = "pales";

            Console.WriteLine(IsEdited(s1, s2));
            Console.WriteLine(IsEdited(s5, s1));
            Console.WriteLine(IsEdited(s1, s3));
            Console.WriteLine(IsEdited(s1, s4));

            Console.ReadKey();
        }

        static bool IsEdited(string s1, string s2)
        {
             
            string getBigger = s1.Length >= s2.Length ? s1 : s2;
            string getSmaller = s1.Length >= s2.Length ? s2 : s1;
            int count = 0;
            
            for (int i = 0; i < getBigger.Length; i++)
            {
                if (!getSmaller.Contains(getBigger[i])) count++;
            }
            Console.WriteLine("Input: {0} => Output: {1} - Edited {2} chars",getBigger,getSmaller, count);
            return count == 1 ? true : false;

        }
    }
}
