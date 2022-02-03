using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._1RemoveDups
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLinkedList(CreateLinkedList());
            Console.WriteLine();
            WriteLinkedList(RemoveDuplicate(CreateLinkedList()));


        }

        static LinkedList<int> CreateLinkedList()
        {
            LinkedList<int> input = new LinkedList<int>();

            for (int i = 1; i <= 50; i++)
            {
                input.AddLast(i);
                //Add some int for duplicate them
                if (i % 4 == 0) input.AddLast(i);
            }
            return input;
        }

        static LinkedList<int> RemoveDuplicate(LinkedList<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (i + 1 == input.Count) return input;
                else if (input.ElementAt(i) == input.ElementAt(i + 1)) input.Remove(i + 1);
            }
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
