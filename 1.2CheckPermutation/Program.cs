using System;
using System.Linq;

namespace _1._2CheckPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "asdf";
            string s2 = "asdf";
            string s3 = "sdaf";
            string s4 = "asas";
            string s5 = "asdfdf";
            Console.WriteLine(Permutation(s1, s2));
            Console.WriteLine(Permutation(s1, s3));
            Console.WriteLine(Permutation(s1, s4));
            Console.WriteLine(Permutation(s1, s5));
            Console.ReadKey();
        }

        private static bool Permutation(string str1, string str2)
        {
            //Check length first
            if (str1.Length != str2.Length) return false;

            //Sort strings and Compare
            return SortOfArray(str1).Equals(SortOfArray(str2));

        }
        public static string SortOfArray(string s)
        {
            //Convert string to char array, sort and convert new string
            char[] arrayOfString = s.ToCharArray();
            Array.Sort(arrayOfString);
            return new string(arrayOfString);
        }

        //Second Solution
        /*
              private static bool Permutation(string str1, string str2)
              {
                  //Check length first
                  if (str1.Length != str2.Length) return false;
                  char[] arr1 = str1.ToCharArray();
                  char[] arr2 = str2.ToCharArray();

                  Array.Sort(arr1);
                  Array.Sort(arr2);
                  for (int i = 0; i < str1.Length; i++)
                  {
                      if (arr1[i] != arr2[i]) return false;
                  }

                  return true;

              }
      */
    }
}
