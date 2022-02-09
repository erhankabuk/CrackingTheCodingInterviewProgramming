using System;
using System.Collections.Generic;

namespace _2._7Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 3, 1, 5, 9, 7, 2, 1 };
            int[] arr2 = { 4, 6, 7, 2, 1 };

            Console.WriteLine(CheckIntersection(arr1, arr2));

        }

        static bool CheckIntersection(int[] arr1, int[] arr2)
        {

            LinkedList<int> list1 = new LinkedList<int>(arr1);
            LinkedList<int> list2 = new LinkedList<int>(arr2);
            LinkedListNode<int> node1 = new LinkedListNode<int>(0);
            LinkedListNode<int> node2 = new LinkedListNode<int>(0);
            list1.AddLast(node1);
            list2.AddLast(node2);

            while (node1 != null || node2 != null)
            {
                //if (node1.Previous.Value != node2.Previous.Value) return false;
                //else if (node1.Previous.Previous.Value == node2.Previous.Previous.Value) return true;
                if (node1.Previous.Value == node2.Previous.Value) return true;
                else return false;
            }

            return false;
        }

    }
}
