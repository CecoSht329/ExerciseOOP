using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;

        public Player(string name, double endurance, double sprint, double dribble, double passing, double shooting)
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

        public double Endurance
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

        public double Sprint
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

        public double Dribble
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


        public double Passing
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

        public double Shooting
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


        public double GetSkillLevel()
        {
            List<double> statsCollection = new List<double>();
            statsCollection.Add(Endurance);
            statsCollection.Add(Sprint);
            statsCollection.Add(Dribble);
            statsCollection.Add(Passing);
            statsCollection.Add(Shooting);

            return statsCollection.Average();
        }

       

        private static bool IsStatValid(double value)
        {
            return value < 0 || value > 100;
        }
    }
}
