using System;
using System.Collections.Generic;
using System.Linq;
namespace _04_EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            Dictionary<int, int> evenNum = new Dictionary<int, int>();
            for (int i = 0; i < countOfNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (!evenNum.ContainsKey(currentNumber))
                {
                    evenNum[currentNumber] = 0;

                }
                evenNum[currentNumber]++;
                
            }
            Console.WriteLine(evenNum.Single(n=>n.Value%2==0).Key);
        
        }
    }
}
