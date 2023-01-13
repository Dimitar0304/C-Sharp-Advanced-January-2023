using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            // first we recive n lines of input wich will can be one of these operations
            //if is 1 we have to push x element to Stack
            //if is 2 we have to pop last element
            //if is 3 we will have to print maximum element in stack
            //if it is 4 we will have to print minimum element in stack
            //after all lines we will have to print all element in stack.
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length>1)
                {
                    int numberToPush = int.Parse(input[1]);
                    stack.Push(numberToPush);
                }
                else if (input[0]=="2")
                {
                    if (stack.Count>0)
                    {
                        stack.Pop();
                    }
                    
                }
               else if (input[0]=="3")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            while (stack.Count!=1)
            {
                Console.Write($"{stack.Pop()}, ");
            }
            Console.Write(stack.Pop());
        }
    }
}
