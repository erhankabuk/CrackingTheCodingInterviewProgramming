using System;

namespace _8._5RecursiveMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            Console.WriteLine(GetSumOfAll(a, b));
            Console.ReadKey();
        }

        public static int GetSumOfAll(int a, int b)
        {
            int smaller = a < b ? a : b;
            int bigger = a > b ? a : b;

            if (smaller == 0) return 0;
            else if (smaller == 1) return bigger;

            //int halfOfSmaller = smaller >>1;//Divide by 2
            int halfOfSmaller = smaller / 2;
            int sumOfHalf = GetSumOfAll(halfOfSmaller, bigger);
            return smaller % 2 == 0 ? sumOfHalf + sumOfHalf : sumOfHalf + sumOfHalf + bigger;

        }


    }
}
