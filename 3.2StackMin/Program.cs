using System;
using System.Collections;
using System.Collections.Generic;

namespace _3._2StackMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> mainStack = CreateStack();
            int input = 45;
            Console.WriteLine(string.Join(" ", mainStack));
            Console.WriteLine(PushToStack(mainStack, input));
            //Console.WriteLine(PopFromStack(mainStack));         

        }


        static Stack<int> CreateStack()
        {
            Random random = new Random();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(random.Next(1, 50));
            }
            return stack;

        }

        static int PushToStack(Stack<int> mainStack, int input)
        {
            Stack<int> tempStack = mainStack;
            int lengthOfMainStack = mainStack.Count;
            int minValueOfStack = input;
            int check;

            for (int i = 0; i < lengthOfMainStack; i++)
            {
                check = tempStack.Peek();
                if (check <= minValueOfStack) minValueOfStack = check;
                tempStack.Pop();
            }
            mainStack.Push(input);
            return minValueOfStack;
        }


        static int PopFromStack(Stack<int> mainStack)
        {

            Stack<int> tempStack = mainStack;
            int lengthOfMainStack = mainStack.Count;
            int minValueOfStack = tempStack.Peek();
            int check;

            for (int i = 0; i < lengthOfMainStack - 1; i++)
            {
                check = tempStack.Peek();
                if (check <= minValueOfStack) minValueOfStack = check;
                tempStack.Pop();
            }

            mainStack.Pop();

            return minValueOfStack;
        }


    }
}
