using System;
using System.Collections.Generic;
using System.Linq;
namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            //we own a fashon boutique and 1time at month we recive box of clothes which are intigers sep by space
            //we must to arrage clothes to store in racks every rack has capacity and it is a intiger inserted by console
            //we will think about algorithm for sum clothes intigers and add them to rack while rack is equal to capacity
            //then if it have more clothes in box we get a new rack and insert in it.
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> box = new Stack<int>(arr);
            int rackCapacity = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int rackCounter = 0;

            while (box.Count!=0)
            {
                int currentCloth = box.Pop();
                currentSum += currentCloth;
                if (currentSum>rackCapacity)
                {

                    currentSum = currentCloth;
                    rackCounter++;
                }
                if (box.Count == 0 || currentSum >= rackCapacity)
                {
                    rackCounter++;
                    currentSum = 0;
                }
                if (currentSum==rackCapacity)
                {
                    currentSum = 0;

                    rackCounter++;
                }
                
            }
            Console.WriteLine(rackCounter);
        }
    }
}
