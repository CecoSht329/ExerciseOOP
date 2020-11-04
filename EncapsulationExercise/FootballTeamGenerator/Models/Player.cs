using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const double statCount = 5;
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
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

        public int Endurance
        {
            get => endurance;
            private set
            {
                if (IsStatValid(value))
                {
                    throw new ArgumentException(string.Format(Message.InvalidStatMessage, nameof(Endurance)));
                }
                endurance = value;
            }
        }

        public int Sprint
        {
            get => sprint;
            private set
            {
                if (IsStatValid(value))
                {
                    throw new ArgumentException(string.Format(Message.InvalidStatMessage, nameof(Sprint)));
                }
                sprint = value;
            }
        }

        public int Dribble
        {
            get => dribble;
            private set
            {
                if (IsStatValid(value))
                {
                    throw new ArgumentException(string.Format(Message.InvalidStatMessage, nameof(Dribble)));
                }
                dribble = value;
            }
        }


        public int Passing
        {
            get => passing;
            private set
            {
                if (IsStatValid(value))
                {
                    throw new ArgumentException(string.Format(Message.InvalidStatMessage, nameof(Passing)));
                }
                passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;
            private set
            {
                if (IsStatValid(value))
                {
                    throw new ArgumentException(string.Format(Message.InvalidStatMessage, nameof(Shooting)));
                }
                shooting = value;
            }
        }

        public double OverallStat
            => (Endurance + Sprint + Dribble + Passing + Shooting) / statCount;
       



        private static bool IsStatValid(double value)
        {
            return value < 0 || value > 100;
        }
    }
}
