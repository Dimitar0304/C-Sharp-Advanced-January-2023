using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfColthesRecive = int.Parse(Console.ReadLine());

            Dictionary<string,Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < countOfColthesRecive; i++)
            {
                string[] clothesColor = Console.ReadLine().Split(new string[]{" -> ",","}, StringSplitOptions.RemoveEmptyEntries);
                string colorïnp = clothesColor[0];
                if (!wardrobe.ContainsKey(colorïnp))
                {
                    wardrobe[colorïnp] = new Dictionary<string, int>();
                }
                for (int y = 1; y < clothesColor.Length; y++)
                {
                    string currentCloth = clothesColor[y];
                    if (!wardrobe[colorïnp].ContainsKey(currentCloth))
                    {
                        wardrobe[colorïnp].Add(currentCloth, 0);
                    }
                    wardrobe[colorïnp][currentCloth]++;
                   
                }


            }
            string[] outPutInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string color = outPutInfo[0];
            string clothing = outPutInfo[1];
            foreach (var colour in wardrobe)
            {
                Console.WriteLine($"{colour.Key} clothes:");
                foreach (var cloth in colour.Value)
                {
                    Console.Write($"* {cloth.Key} - {cloth.Value}");
                    if (cloth.Key==clothing&&colour.Key==color)
                    {
                        Console.Write($" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
