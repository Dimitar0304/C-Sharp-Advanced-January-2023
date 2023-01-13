using System;
using System.Collections.Generic;
using System.Linq;
namespace _04FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            //we have company for fastFood
            //in first line we recive ready fast food for a currentDay
            //in second line we recive sequance of orders sep by space
            //we have to start get the orders we have to remove current order in queue and decrease  readyFastfood
            //if our fastfood can't get all orders we print queue
            //if it print "Orders complete"
            // also we will have to know bigest order and print it 
            int biggestOrder = 0;
            int food = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(arr);
            biggestOrder = queue.Max();
            while (queue.Count != 0)
            {
                int currentOrder = queue.Peek();
                if (food<currentOrder)
                {
                    break;
                }
                if (food == 0)
                {
                    break;
                }        
                else if (food >= currentOrder)
                {
                    queue.Dequeue();
                    food -= currentOrder;
                }
   
            }
            if (queue.Count > 0)
            {
                Console.WriteLine(biggestOrder);


                Console.Write($"Orders left: {string.Join(" ", queue)}");


            }
            else
            {
                Console.WriteLine(biggestOrder);
                Console.WriteLine("Orders complete");

            }
        }
    }
}
