using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem_10._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Dictionary<string, List<string>> forceSideMembers = new Dictionary<string, List<string>>();
            //while the "Lumpawaroo". command recive one of these command forceSide | forceUser and forceUser->forceSide
            string comand = Console.ReadLine();
            while (comand!= "Lumpawaroo")
            {
                if (comand.Contains('|'))
                {
                    string[] comandInfo = comand.Split(" | ",StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = comandInfo[0];
                    string forceUser = comandInfo[1];
                    
                    if (!forceSideMembers.Values.Any(u=>u.Contains(forceUser)))
                    {
                        if (!forceSideMembers.ContainsKey(forceSide))
                        {
                            forceSideMembers.Add(forceSide, new List<string>());
                        }

                        forceSideMembers[forceSide].Add(forceUser);
                    }
                    
                   
                }
                else 
                {

                    string[] comandInfo = comand.Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = comandInfo[0];
                    string forceSide = comandInfo[1];

                    foreach (var side in forceSideMembers)
                    {
                        if (side.Value.Contains(forceUser))
                        {
                            side.Value.Remove(forceUser);
                            break;
                        }
                        
                    }
                    if (!forceSideMembers.ContainsKey(forceSide))
                    {
                        forceSideMembers.Add(forceSide, new List<string>());
                    }
                    forceSideMembers[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    

                }
                



                comand = Console.ReadLine();
            }
            foreach (var side in forceSideMembers.OrderByDescending(s=>s.Value.Count).ThenBy(s=>s.Key))
            {
                if (side.Value.Count>0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    foreach (var member in forceSideMembers[side.Key].OrderBy(m => m))
                    {
                        Console.WriteLine($"! {member}");
                    }
                }
                
            }
        }
    }
}
