using System;
using System.Collections.Generic;
using System.Linq;
namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            //while one of these sequance are become to zero end the while 
            //bottles are in stack
            //cups are inn queue
            //If the current bottle has N water, you give the first entered cup N water and reduce its integer value by N.
            //wwhen cups reach less or 0 it be will removed
            //if cup capacity is greater than current bottle i get next bottle until reduce a cup capacity to 0 or less
            //when currentBottle capacity is greater than currentCup diff between bottleCapacity - cupcapacity is wasted and i 
            // must to print all wasted water in the end of program

            //output
            //If you have managed to fill up all of the cups, print the remaining water bottles, from the last entered – to the first, 
            //otherwise you must print the remaining cups, by order of entrance – from the first entered – to the last. 

            //o	"Bottles: {remainingBottles}" or "Cups: {remainingCups}"
            //On the second line, print the wasted litters of water in the following format: "Wasted litters of water: {wastedLittersOfWater}".

            int[] cupsValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] bottlesValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(cupsValues);
            Stack<int> bottles = new Stack<int>(bottlesValues);
            int wastedWater = 0;

            while (true)
            {
                if (cups.Count == 0)
                {
                    break;
                }
                else if (bottles.Count == 0)
                {
                    break;
                }
                int currentBottle = bottles.Pop();
                int currentCup = cups.Dequeue();

                if (currentBottle >= currentCup)
                {
                    //filling
                    currentBottle -= currentCup;

                    wastedWater += currentBottle;

                }
                else
                {
                    currentCup -= currentBottle;
                    while (currentCup != 0 && bottles.Count != 0)
                    {
                        currentBottle = bottles.Pop();
                        if (currentBottle >= currentCup)
                        {
                            wastedWater += currentBottle - currentCup;
                            break;
                        }
                        else
                        {
                            currentCup -= currentBottle;
                        }

                    }
                }

            }

            if (cups.Count == 0)
            {
                Console.Write("Bottles: ");
                while (bottles.Count != 0)
                {
                    Console.Write($"{bottles.Pop()} ");
                }


                Console.WriteLine();
            }


            else
            {
                Console.Write("Bottles: ");
                while (cups.Count != 0)
                {


                    Console.Write($"{cups.Dequeue()} ");

                }
                Console.WriteLine();
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
