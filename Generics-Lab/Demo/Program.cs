using System;
using System.Collections.Generic;

namespace Demo
{
    public class Program
    {
        static void Main(string[] args)

        {
            List<string> stringArray = new List<string>()
           {
               "edno","dwe","tri","4eteri"

           };
            List<int> itigerList = new List<int>()
            {
                1,2,3,4
            };
            List<bool> boolList = new List<bool>()
            {
                false,false, true,true
            };

            Print<bool>(boolList);

            void Print<T>(List<T> elements)
            {
                int counter = 0;
                foreach (var item in elements)
                {
                    counter++;
                    Console.Write($"{counter}-{item} ");
                }
            }




        }
       
    }
}
