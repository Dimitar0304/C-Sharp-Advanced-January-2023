using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> FirstSet = new HashSet<int>();
            HashSet<int> SecondSet = new HashSet<int>();

            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n1 = input[0];
            int n2 = input[1];

            for (int i = 0; i < n1; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                FirstSet.Add(currentNumber);
            }
            for (int i = 0; i < n2; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                SecondSet.Add(currentNumber);
            }

            List<int> commonNumbersInTwoSets = new List<int>();

            foreach (var item in FirstSet)
            {
                foreach (var item2 in SecondSet)
                {
                    if (item==item2)
                    {
                        commonNumbersInTwoSets.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",commonNumbersInTwoSets));
        }
    }
}
