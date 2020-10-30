using PizzaCalories.Models;
using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string pizzaName = Console.ReadLine()
                    .Split()[1];

                string[] input = Console.ReadLine()
               .Split();

                string flourType = input[1];
                string bakingTech = input[2];
                double weight = double.Parse(input[3]);

                Dough dough = new Dough(flourType, bakingTech, weight);

                Pizza pizza = new Pizza(pizzaName, dough);

                string command = "";
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] toppingInput = command
                   .Split();

                    string toppingType = toppingInput[1];
                    double toppingWeight = double.Parse(toppingInput[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddTopping(topping);
                }
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
