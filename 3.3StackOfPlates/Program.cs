using System;
using System.Collections;
using System.Collections.Generic;

namespace _3._3StackOfPlates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Stack> stacks = new List<Stack>();
            int stackCapacity = 10;
         
            stacks.AddRange(CreateStack(stackCapacity));
            stacks.AddRange(CreateStack(stackCapacity));
            stacks.AddRange(CreateStack(stackCapacity));

          PushToStack(stacks, 100, stackCapacity);
            PopFromStack(stacks);


            foreach (var item in stacks)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2);
                }
                Console.WriteLine();
            }

            void PushToStack(List<Stack> stackList, int input, int capacity)
            {

                Stack lastStackInStacks = stackList[stackList.Count - 1];

                if (lastStackInStacks != null && lastStackInStacks.Count < capacity) lastStackInStacks.Push(input);
                else
                {
                    Stack newStack = new Stack(capacity);
                    newStack.Push(input);
                    stacks.Add(newStack);

                }
                Console.WriteLine("push "+input );

            }
            int PopFromStack(List<Stack> stacks)
            {
                Stack lastStackInStacks = stacks[stacks.Count - 1];
                int poppedValue = (int)lastStackInStacks.Peek();
                
                Console.WriteLine("Pop "+poppedValue);

                if (lastStackInStacks != null) lastStackInStacks.Pop();
                if (lastStackInStacks.Count == 0) stacks.Remove(stacks[stacks.Count - 1]);

                return poppedValue >= 0 ? poppedValue : -1;

            }
        }

        public static IEnumerable<Stack> CreateStack(int capacity)
        {
            Random random = new Random();
            Stack stack = new Stack();

            for (int i = 0; i < capacity; i++)
            {
                stack.Push(random.Next(0,50));
            }

            yield return stack;
        }


       
    }
}
