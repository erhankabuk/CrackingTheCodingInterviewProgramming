using System;
using System.Collections.Generic;

namespace _2._0LinkedListNode
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> list = CreateLinkedList();
            //Create and add Link
            LinkedListNode<int> node = new LinkedListNode<int>(0);
            list.AddLast(node);

            WriteLinkedList(list);
            Console.WriteLine(node.Previous.Value);


        }

        
        static LinkedList<int> CreateLinkedList()
        {
            Random random = new Random();
            LinkedList<int> list = new LinkedList<int>();
          
            for (int i = 0; i < 20; i++)
            {
                list.AddLast(random.Next(0, 10));
            }
            return list;
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
