using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._2ReturnKthToLast
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 15;
            Console.WriteLine("Kth element of LinkedList is : "+ ReturnKthToLast(CreateLinkedList(), k));
        }

        static LinkedList<int> CreateLinkedList()
        {
            LinkedList<int> input = new LinkedList<int>();
            for (int i = 1; i <= 50; i++)
            {
                input.AddLast(i);               
            }
            return input;
        }
       
        static int ReturnKthToLast(LinkedList<int> input, int k)
        {
            int result = input.ElementAt(input.Count - k);
            return result;
        }
   
        //Second Solution

    }
}
