using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._5SumLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Sum of two lists: "+SumOfLists(digitsToNumber(CreateLinkedList()), digitsToNumber(CreateLinkedList())));
        }

        static LinkedList<int> CreateLinkedList()
        {
            Random random = new Random();
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < 3; i++)
            {
                list.AddLast(random.Next(0, 10));
            }
            return list;
        }

        static int digitsToNumber(LinkedList<int> input)
        {
            string number = "";
            for (int i = input.Count-1; i >=0; i--)
            {
                number += input.ElementAt(i);
            }
            WriteLinkedList(input);           
            Console.WriteLine(number);
            return int.Parse(number);
        }
        static int SumOfLists(int input1,int input2)
        {           
            return input1+input2;
        }


        static void WriteLinkedList(LinkedList<int> input)
        {
           
            foreach (var item in input)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }



    }
}
