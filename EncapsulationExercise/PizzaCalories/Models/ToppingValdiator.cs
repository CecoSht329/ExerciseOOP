﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace PizzaCalories.Models
{
    public static class ToppingValdiator
    {
        private static Dictionary<string, double> toppingType;

        public static bool IsValid(string type)
        {
            Initialize();
            return toppingType.ContainsKey(type.ToLower());
        }

        public static double GetModifier(string type)
        {
            Initialize();
            return toppingType[type.ToLower()];
        }

        private static void Initialize()
        {
            if (toppingType != null)
            {
                return;
            }
            toppingType = new Dictionary<string, double>
            {
                { "meat", 1.2 },
                { "veggies", 0.8 },
                { "cheese", 1.1 },
                { "sauce", 0.9 }
            };
        }
    }
}
