using System;
using System.Collections.Generic;
using System.Collections;

namespace _3._5SortStack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> mainStack = CreateMainStack();
            Console.Write("Main Stack : ");
            foreach (var item in mainStack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("SortStack  : ");
            Stack<int> sortedStack = SortStack(mainStack);
            foreach (var item in sortedStack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("SortStack2 : ");
            Stack<int> sortedStack2 = SortStack2(mainStack);
            foreach (var item in sortedStack2)
            {
                Console.Write(item + " ");
            }
        }

        //Create Main Stack
        static Stack<int> CreateMainStack()
        {
            Random random = new Random();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(random.Next(1, 50));
            }
            return stack;

        }
        //My Solution
        static Stack<int> SortStack(Stack<int> stack)
        {
            Stack<int> bufferStack = new Stack<int>();
            int temp;
            while (stack.Count > 0)
            {
                temp = stack.Pop();
                while (bufferStack.Count > 0 && temp < bufferStack.Peek())
                {
                    stack.Push(bufferStack.Pop());
                }
                bufferStack.Push(temp);
            }

            while (bufferStack.Count != 0)
            {
                stack.Push(bufferStack.Pop());
            }

            return stack;
        }

 
    }
}
