using System;
using System.Collections.Generic;
using System.Linq;
namespace _03_PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int coutOfChemicalsElements = int.Parse(Console.ReadLine());
            HashSet<string> chemicalElements = new HashSet<string>();
            for (int i = 0; i < coutOfChemicalsElements; i++)
            {
                string[] elementsInput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                for (int y = 0; y < elementsInput.Length; y++)
                {
                    string currentElement = elementsInput[y];
                    if (!chemicalElements.Contains(currentElement))
                    {
                        chemicalElements.Add(currentElement);
                    }
                }
                
            }
            chemicalElements = chemicalElements.OrderBy(c => c).ToHashSet();
            Console.WriteLine(string.Join(" ",chemicalElements));
        }
    }
}
