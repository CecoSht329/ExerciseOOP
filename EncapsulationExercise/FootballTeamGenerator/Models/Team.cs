
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;

namespace FootballTeamGenerator.Models
{
    public class Team
    {
        private string name;
        private List<Player> players;
        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Message.InvalidNameMessage);
                }
                name = value;
            }
        }

        //public double Rating
        //    => this.GetRatng();

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            if (players.Any(p => p.Name == name))
            {
                players.Remove(players.FirstOrDefault(p => p.Name == name));
            }
            else
            {
                throw new ArgumentException(string.Format(Message.MissingPlayerMessage, name, Name));
            }
        }

        public double GetRatng()
        {
            List<double> playerSkillLevelCollection = new List<double>();

            foreach (Player player in players)
            {
                playerSkillLevelCollection.Add(player.GetSkillLevel());
            }
            if (playerSkillLevelCollection.Count == 0)
            {
                return 0;
            }
            return Math.Round(playerSkillLevelCollection.Average());
        }
    }
}
