using FootballTeamGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                string teamName = command[1];
                try
                {
                    if (input.StartsWith("Team"))
                    {
                        Team team = new Team(teamName);
                        teams.Add(team);
                    }
                    else if (input.StartsWith("Add"))
                    {
                        //If you receive a command to add a Player to a missing Team,
                        //print "Team [team name] does not exist."
                        //endurance, sprint, dribble, passing and shooting
                        teamName = command[1];

                        string playerName = command[2];
                        int endurance = int.Parse(command[3]);
                        int sprint = int.Parse(command[4]);
                        int dribble = int.Parse(command[5]);
                        int passing = int.Parse(command[6]);
                        int shooting = int.Parse(command[7]);

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        if (teams.Any(t => t.Name == teamName))
                        {
                            teams.FirstOrDefault(t => t.Name == teamName).AddPlayer(player);
                        }
                        else
                        {
                            throw new ArgumentException(string.Format(Message.NonExistentTeam, teamName));
                        }

                    }
                    else if (input.StartsWith("Remove"))
                    {
                        //Remove; Arsenal; Aaron_Ramsey
                        string playerName = command[2];
                        if (teams.Any(t => t.Name == teamName))
                        {
                            teams.FirstOrDefault(t => t.Name == teamName).RemovePlayer(playerName);
                        }
                        else
                        {
                            throw new ArgumentException(string.Format(Message.NonExistentTeam, teamName));
                        }
                    }
                    else if (input.StartsWith("Rating"))
                    {
                        if (teams.Any(t => t.Name == teamName))
                        {
                            Team team = teams.FirstOrDefault(t => t.Name == teamName);
                            
                            Console.WriteLine($"{team.Name} - {team.GetRatng()}");
                        }
                        else
                        {
                            throw new ArgumentException(string.Format(Message.NonExistentTeam, teamName));
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
