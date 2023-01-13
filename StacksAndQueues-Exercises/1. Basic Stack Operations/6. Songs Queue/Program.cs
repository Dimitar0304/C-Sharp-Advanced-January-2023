using System;
using System.Collections.Generic;
using System.Linq;
namespace _6._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //on first line we will be given a sequance of songs
            //on next lines until the queue.count==0 we might be recive command at these type:
            //Add() add song if it not contains in the queue if it contains print-"{song} is already contained!"
            //Play() remove a song from queue
            //Show() - print all queue currently by ,and space
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> songList = new Queue<string>(songs);

            while (songList.Count!=0)
            {
                string command = Console.ReadLine();
                if (command.Length>4)
                {
                    string songToAdd = string.Empty;
                    List<string> commandInfo = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
                    songToAdd = commandInfo[1];
                    for (int i = 2; i < commandInfo.Count; i++)
                    {
                        songToAdd += " " + commandInfo[i];
                    }
                    
                    
                    
                    if (!songList.Contains(songToAdd))
                    {
                        songList.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                }
                else if (command=="Play")
                {
                    if (songList.Count>0)
                    {
                        songList.Dequeue();
                    }
                    
                }
                else if (command=="Show")
                {
                    if (songList.Count>0)
                    {

                        Console.WriteLine($"{string.Join(", ",songList)}");
                       
                    }
                }
                
            }
            Console.WriteLine("No more songs!");
        }
    }
}
