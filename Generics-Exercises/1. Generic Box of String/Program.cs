﻿using System;

namespace GenericBoxofString
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Box<string> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Items.Add(input);
            }
            Console.WriteLine(box.ToString());
        }
    }
}
