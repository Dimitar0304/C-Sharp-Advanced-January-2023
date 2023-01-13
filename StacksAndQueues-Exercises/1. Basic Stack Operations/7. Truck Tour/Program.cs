using System;
using System.Collections.Generic;
using System.Linq;
namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            //we have petrol pumps on first line we recive numbers of pumps intiger
            //with for loop from 0 to <n
            //we recive pair elements in array [0]index = amount of fuel that current pump give to truck
            //[1] = is intiger wich is kilometers to next oil pump and 1 liter of fuel == 1 kilometers
            // find the first oil pump that helps to truck to pass trought all the route of pumps

            int count = int.Parse(Console.ReadLine());
            Queue<int[]> oilPumps = new Queue<int[]>();
            for (int i = 0; i < count; i++)
            {
                int[] pumps = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                oilPumps.Enqueue(pumps);
            }
            int startIndex = 0;
            while (true)
            {
                bool isComplete = true;
                int totalLiters = 0;
                foreach (var pump in oilPumps)
                {
                    int liters = pump[0];
                    int distance = pump[1];
                    totalLiters += liters;
                    if (totalLiters - distance *1<0)
                    {
                        startIndex++;
                        int[] currentPump = oilPumps.Dequeue();
                        oilPumps.Enqueue(currentPump); 
                        isComplete = false;
                        break;
                    }
                    totalLiters -= distance * 1;
                }
                if (isComplete==true)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
            
        }
    }
}
