using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _11.__Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            //at first line we recive a price for one bullet
            //second line we size of gun barrel when gun barrelCount == currentFiredBulleds print Reloading
            // third line we recive a bullets sequance of int wich will be insert in Stack 
            // fourth line we recive a locks sequance of int which we will insert in queue
            //fifht line we recive a valueOfInteligence => a price from the safe

            //we shoot with bullets from back to start and when the bullet is less or equal to first lock we remove lock and print
            //"Bang"
            //if the bullet is more than lock we print "Ping" and in all cases we remove bullets

            //we must to have a decimal counter wich add on each fired bullet price for one bullet
            //if all lock are destroyed we print "2 bullets left. Earned $1300" and from valueOfinteligents decrease decimal counter
            //if john is out of bullet and has more locks print "Couldn't get through. Locks left: {locks.count}"


            decimal bulletPrice = decimal.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            int[] bulletInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] locksInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            decimal valueOfInteligence = decimal.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletInput);
            Queue<int> locks = new Queue<int>(locksInput);
            decimal expenses = 0;
            int counter = 0;

            while (locks.Count!=0&&bullets.Count!=0)
            {
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();
                counter++;
                expenses += bulletPrice;
                
                
                if (currentBullet<=currentLock)
                {
                    Console.WriteLine("Bang");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping");
                }
                if (counter == gunBarrel&&bullets.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    counter = 0;
                }

            }

            if (locks.Count==0)
            {
                decimal earnedValue = valueOfInteligence - expenses;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedValue:f0}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }

        }
    }
}
