using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_9.__SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            //until the "exam finished". we recive a commands in these two cases
            //username-language-points add to usernameInfo dic 
            //also we can recive and username-banned and remove the username from userinfo dic but save his submissions
            //at other dic for langluage and the currentlaguageCount
            //then print all usernames order by points then by username
            //after that print the langluages order by cout of submissionOfCurrentLanguage then by languageName 

            string command = Console.ReadLine();
            Dictionary<string, int> userInfo = new Dictionary<string, int>();
            Dictionary<string, int> submissionInfo = new Dictionary<string, int>();
            while (command!= "exam finished")
            {
                string[] commandInfo = command.Split('-', StringSplitOptions.RemoveEmptyEntries);
                if (commandInfo.Length==3)
                {
                    //add case to userInfo Dic
                    string username = commandInfo[0];
                    string languge = commandInfo[1];
                    int points = int.Parse(commandInfo[2]);

                    if (!userInfo.ContainsKey(username))
                    {
                        userInfo.Add(username, points);
                    }
                   else if (userInfo[username]<points)
                    {
                        userInfo[username] = points;
                    }
                    //add to language Dic
                    if (!submissionInfo.ContainsKey(languge))
                    {
                        submissionInfo.Add(languge, 0);
                    }
                    submissionInfo[languge]++;
                    

                }
                else if (commandInfo.Length==2)
                {
                    //ban case
                    string usernameToBan = commandInfo[0];
                    if (userInfo.ContainsKey(usernameToBan))
                    {
                        userInfo.Remove(usernameToBan);
                    }
                }



                command = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var user in userInfo.OrderByDescending(u=>u.Value).ThenBy(u=>u.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var language in submissionInfo.OrderByDescending(l=>l.Value).ThenBy(l=>l.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
