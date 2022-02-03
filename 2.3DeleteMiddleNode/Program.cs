using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._3DeleteMiddleNode
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLinkedList(CreateLinkedList());
            Console.WriteLine();
            WriteLinkedList(DeleteMiddleNode(CreateLinkedList()));
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

        static LinkedList<int> DeleteMiddleNode(LinkedList<int> input)
        {
            input.Remove(input.Count() / 2);
            //Try with runner approaching.
            return input;
        }

        static void WriteLinkedList(LinkedList<int> input)
        {
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}
