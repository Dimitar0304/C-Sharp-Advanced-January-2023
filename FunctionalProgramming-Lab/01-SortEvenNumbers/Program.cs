﻿using System;
using System.Linq;

namespace _01_SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(n => int.Parse(n)).Where(n=>n %2==0).OrderBy(n=>n).ToArray();

            Console.WriteLine(string.Join(", ",numbers));

        }
    }
}
