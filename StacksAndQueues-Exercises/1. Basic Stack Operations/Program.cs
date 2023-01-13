using System;
using System.Collections.Generic;
using System.Linq;
namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //on the first line we recive 3 numbers 
            //first is N - wich is numbers to Push in Stack
            //second is S - how many numbers we will pop of stack
            //third is X - we will iterate by all of stack and print true if we find X-number
            //if it not exsist we will print smallest number in stack
            //if stack is empty we will print 0 at output
            int smallestNum = int.MaxValue;
           
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];
            int[] stackPushes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(stackPushes);
            if (s == stack.Count)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");

            }
            else
            {
                smallestNum = stack.Min();
                Console.WriteLine(smallestNum);


            }
        }
    }
}
