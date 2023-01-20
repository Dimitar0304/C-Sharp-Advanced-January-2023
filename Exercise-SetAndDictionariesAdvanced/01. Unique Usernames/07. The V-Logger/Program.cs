using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            //we have to write a program that keep a Vlogar and his followers
            //we recive some commands until the "Statistics" command 
            //they will be string[1] will make diff between two command
            //it can be joined - after this command we add a vloggerName if it is exsist ignore this command
            //it can be followed - after this command firtsVlogerName follows a vlogger with second vloggerName in the input
            //some cases:

            // if firstVloggerName already follows this secondVlogger ignore the command
            //one vlogger can not follow himself.
            //if one of given vloggerNames don't exist in dictionary ignore.

            //after statistic command print the dictionary
            //print the vlogger with most followers.
            //and his followers
            //sort by lenght
            //if vlogger no followers just print his name
            //lastly print other vlogger orderd by descending by their followersCount then by a vloggers that he follows in ascendi
            //

            Dictionary<string, Dictionary<string, HashSet<string>>> vlgogers = new Dictionary<string, Dictionary<string, HashSet<string>>>();


            while (true)
            {
                string[] commandArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commandArgs[0] == "Statistics")
                {
                    break;
                }
                string typeOfCommand = commandArgs[1];
                if (typeOfCommand == "joined")
                {
                    string vloggerName = commandArgs[0];
                    if (!vlgogers.ContainsKey(vloggerName))
                    {
                        vlgogers.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                        vlgogers[vloggerName].Add("followers", new HashSet<string>());
                        vlgogers[vloggerName].Add("folloing", new HashSet<string>());
                    }
                }
                else if (typeOfCommand == "followed")
                {
                    string vlogger = commandArgs[0];
                    string vloggerToFollow = commandArgs[2];
                    //case checks
                    if (vlgogers.ContainsKey(vlogger) && vlgogers.ContainsKey(vloggerToFollow) && vlogger != vloggerToFollow)
                    {
                        vlgogers[vlogger]["folloing"].Add(vloggerToFollow);
                        vlgogers[vloggerToFollow]["followers"].Add(vlogger);
                    }


                }

            }
            Console.WriteLine($"The V-Logger has a total of {vlgogers.Count} vloggers in its logs.");
            int counter = 1;
            Dictionary<string, Dictionary<string, HashSet<string>>> orderedVloggers = vlgogers
    .OrderByDescending(v => v.Value["followers"].Count)
    .ThenBy(v => v.Value["folloing"].Count)
    .ToDictionary(v => v.Key, v => v.Value);
            foreach (var vlogger in orderedVloggers)
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["folloing"].Count} following");

                if (counter == 1)
                {
                    //Try SortedSet for vloggers 
                    List<string> orderedFollowers = vlogger.Value["followers"]
                        .OrderBy(f => f)
                        .ToList();

                    foreach (var follower in orderedFollowers)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                counter++;
            }
        }
    }
}
