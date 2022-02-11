using System;
using System.Collections;
using System.Collections.Generic;

namespace ThreeInOne
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int length = array.Length;
            int n;
            if (length % 3 == 0) n = length / 3;
            else n = (length / 3) + 1;

            CreateStakes(array, n);

            Console.WriteLine("Hello World!");
        }

        public static void CreateStakes(int[] array, int n)
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            Stack<int> stack3 = new Stack<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (i < n) stack1.Push(array[i]);
                else if (i < 2 * n && i >= n) stack2.Push(array[i]);
                else if (i < 3 * n && i >= 2 * n) stack3.Push(array[i]);
            }

            Console.WriteLine(string.Join(" ", stack1));
            Console.WriteLine(string.Join(" ", stack2));
            Console.WriteLine(string.Join(" ", stack3));

        }
    }
}
