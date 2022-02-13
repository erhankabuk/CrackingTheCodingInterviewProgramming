using System;
using System.Collections;
using System.Collections.Generic;

namespace _3._4QueueViaStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mainStack = new Stack();
            Stack convertedStackToQueue = new Stack();

            mainStack.Push(1);
            mainStack.Push(2);
            mainStack.Push(3);
            mainStack.Push("4");

            AddItem(5);
            PopItem();

            Console.Write("Main stack converted to Queue ");
            foreach (var iteem in convertedStackToQueue)
            {
                Console.Write(iteem + " ");
            }

            //AddMethod
            Stack AddItem<T>(T item)
            {
                int lengthOfMainStack = mainStack.Count + 1;

                if (mainStack == null && convertedStackToQueue != null)
                {
                    foreach (var tempItem in convertedStackToQueue)
                    {
                        mainStack.Push(tempItem);
                        convertedStackToQueue.Pop();
                    }
                }

                mainStack.Push(item);

                //Main Stack
                Console.Write("{0} added to main stack ", item);
                foreach (var iteem in mainStack)
                {
                    Console.Write(iteem + " ");
                }
                Console.WriteLine();

                //MainStack converted to Queue
                for (int i = 0; i < lengthOfMainStack; i++)
                {
                    convertedStackToQueue.Push(mainStack.Pop());
                }

                return convertedStackToQueue;
            }

            Stack PopItem()
            {
                if (mainStack == null && convertedStackToQueue == null) Console.WriteLine("Empty stack.");
                else convertedStackToQueue.Pop();

                return convertedStackToQueue;
            }

        }

    }
}
