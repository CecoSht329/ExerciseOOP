﻿using PizzaCalories.Models;
using System;
using System.Collections.Generic;
namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string backingTechnique;
        private double weight;
        public Dough(string flourType, string bakingTechType, double weight)
        {
            this.FlourType = flourType;
            this.BackingTechnique = bakingTechType;
            this.Weight = weight;
        }

        public string FlourType
        {
            get => flourType;
            private set
            {
                if (!DoughValidator.IsValidFlourType(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public string BackingTechnique
        {
            get => backingTechnique;
            private set
            {
                if (!DoughValidator.IsValidBakingTechnique(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                backingTechnique = value;
            }
        }


        public double Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public double GetTotalCalories()
        {
            return this.Weight
                * 2
                * DoughValidator.GetBackingTechniqueModifier(this.BackingTechnique)
                * DoughValidator.GetFlourModifier(this.FlourType);
        }
    }
}
