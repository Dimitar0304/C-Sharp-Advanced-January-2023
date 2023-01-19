using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int countOfInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfInputs; i++)
            {
                string currentName = Console.ReadLine();
                names.Add(currentName);
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
