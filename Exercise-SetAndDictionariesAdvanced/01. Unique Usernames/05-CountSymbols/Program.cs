using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charCounter = new Dictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (!charCounter.ContainsKey(input[i]))
                {
                    charCounter[input[i]] = 0;
                }
                charCounter[input[i]]++;
            }
            foreach (var item in charCounter.OrderBy(c=>c.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
