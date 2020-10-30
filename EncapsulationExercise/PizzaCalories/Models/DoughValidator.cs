
using System;
using System.Collections.Generic;

namespace PizzaCalories.Models
{
    public static class DoughValidator
    {
        private static Dictionary<string, double> flourTypes;
        private static Dictionary<string, double> bakingTechniques;

        public static bool IsValidFlourType(string type)
        {

            Initialize();
            return flourTypes.ContainsKey(type.ToLower());
        }
        public static bool IsValidBakingTechnique(string type)
        {
            Initialize();
            return bakingTechniques.ContainsKey(type.ToLower());
        }

        public static double GetFlourModifier(string type)
        {
            Initialize();
            return flourTypes[type.ToLower()];
        }

        public static double GetBackingTechniqueModifier(string type)
        {
            Initialize();
            return bakingTechniques[type.ToLower()];
        }
        private static void Initialize()
        {
            if (flourTypes != null || bakingTechniques != null)
            {
                return;
            }

            flourTypes = new Dictionary<string, double>
            {
                { "white", 1.5 },
                { "wholegrain", 1.0 }
            };

            bakingTechniques = new Dictionary<string, double>
            {
                { "crispy", 0.9 },
                { "chewy", 1.1 },
                { "homemade", 1.0 }
            };
        }
    }
}
