using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            //create a file wich will be input file and read from it 
            //and create a writer that writes same text with numbers of lines to another output.file
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            // TODO: write your code here…
            var reader = new StreamReader("../../../input.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                int lineCounter = 1;
                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    while (line!=null)
                    {
                        writer.WriteLine($"{lineCounter} {line}");
                    }
                    lineCounter++;
                }
            }

        }
    }
}


