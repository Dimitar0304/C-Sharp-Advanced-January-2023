using System;
using System.IO;

namespace Streams__Files_and_Directories_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //read lines from input.txt to  console with these code
            var reader = new StreamReader("../../../input.txt");
            using (reader)
            {
                int counter = 1;
                string line = reader.ReadLine();
                Console.WriteLine($"{counter} {line}");
                while (line != null)
                {
                    counter++;
                    if (counter==4)
                    {
                        return;
                    }
                    line = reader.ReadLine();
                    Console.WriteLine($"{counter} {line}");
                    
                }
            }
        }
    }
}
