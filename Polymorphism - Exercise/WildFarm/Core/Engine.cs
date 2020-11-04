
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace WildFarm
{
    public class Engine
    {
        public Engine()
        {

        }
        public void Run()
        {
            var input = "";
            int counter = 0;
            List<Animal> animals = new List<Animal>();
            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    if (counter % 2 == 0)
                    {
                        //animal info
                        var animalInfo = input
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        var type = animalInfo[0];
                        var name = animalInfo[1];
                        var weight = double.Parse(animalInfo[2]);
                        if (type == "Cat" || type == "Tiger")
                        {
                            Feline feline;
                            var livingRegion = animalInfo[3];
                            var breed = animalInfo[4];
                            if (type == "Cat")
                            {
                                feline = new Cat(name, weight, livingRegion, breed);
                            }
                            else
                            {
                                feline = new Tiger(name, weight, livingRegion, breed);
                            }
                            animals.Add(feline);
                        }
                        else if (type == "Hen" || type == "Owl")
                        {
                            Bird bird = null;
                            var wingSize = double.Parse(animalInfo[3]);
                            if (type == "Hen")
                            {
                                bird = new Hen(name, weight, wingSize);
                            }
                            else
                            {
                                bird = new Owl(name, weight, wingSize);
                            }
                            animals.Add(bird);
                        }
                        else if (type == "Dog" || type == "Mouse")
                        {
                            Mammal mammal;
                            var livingRegion = animalInfo[3];
                            if (type==nameof(Dog))
                            {
                                mammal = new Dog(name, weight, livingRegion);
                            }
                            else
                            {
                                mammal = new Mouse(name, weight, livingRegion);
                            }
                            animals.Add(mammal);
                        }
                    }
                    else
                    {
                        //food info
                        var foodInfo = input
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        Food food = null;
                        var foodType = foodInfo[0];
                        var quantity = int.Parse(foodInfo[1]);
                        if (foodType == nameof(Vegetable))
                        {
                            food = new Vegetable(quantity);
                        }
                        else if (foodType == nameof(Fruit))
                        {
                            food = new Fruit(quantity);
                        }
                        else if (foodType == nameof(Seeds))
                        {
                            food = new Seeds(quantity);
                        }
                        else if (foodType == nameof(Meat))
                        {
                            food = new Meat(quantity);
                        }

                        if (food != null)
                        {
                            Console.WriteLine(animals.LastOrDefault().ProduceSound());
                            //animals.firs.Eat(food);
                            animals.LastOrDefault().Eat(food);
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                counter++;
            }
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
