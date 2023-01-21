using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_08_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            //first we have to save lines of input that will be contest:pasword to unlock the contest until the 
            //"end of contests"
            //after that until the "end of submissions" we will recive a lines of input that will be 
            //contest=>passwordContest=>username=>Points for current user on that contest
            //one user can have more than one contest
            //if we recive equal user with contest that will be in but with more points update his point satus
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> usersInfo = new Dictionary<string, Dictionary<string, int>>();

            string contestCommand = Console.ReadLine();
            while (contestCommand != "end of contests")
            {
                string[] contestInfo = contestCommand.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string contestName = contestInfo[0];
                string contestPassword = contestInfo[1];

                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, contestPassword);
                }
                contestCommand = Console.ReadLine();
            }
            string userSubmissons = Console.ReadLine();
            while (userSubmissons != "end of submissions")
            {
                string[] submissionInfo = userSubmissons.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contestName = submissionInfo[0];
                string contestPassword = submissionInfo[1];
                string userName = submissionInfo[2];
                int points = int.Parse(submissionInfo[3]);


                if (contests.ContainsKey(contestName) && contests[contestName] == contestPassword)
                {
                    //in this if we will add user info
                    if (!usersInfo.ContainsKey(userName))
                    {
                        usersInfo.Add(userName, new Dictionary<string, int>());
                    }
                    else if (usersInfo.ContainsKey(userName) && usersInfo[userName].ContainsKey(contestName))
                    {
                        if (usersInfo[userName][contestName] < points)
                        {
                            usersInfo[userName][contestName] = points;
                            continue;
                        }
                    }
                    if (!usersInfo[userName].ContainsKey(contestName))
                    {
                        usersInfo[userName].Add(contestName, points);
                    }
                        
                        
                            
                        

                    

                }

                userSubmissons = Console.ReadLine();
            }
            string bestCandidate = string.Empty;
            int bestScore = 0;
            foreach (var user in usersInfo)
            {
                int currentScore = 0;
                foreach (var contest in user.Value)
                {
                    currentScore += contest.Value;

                }
                if (currentScore > bestScore)
                {
                    bestScore = currentScore;
                    bestCandidate = user.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestScore} points.");

            Console.WriteLine("Ranking:");
            foreach (var user in usersInfo.OrderBy(u=>u.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var contest in  user.Value.OrderByDescending(c=>c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
