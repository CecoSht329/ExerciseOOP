using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Animals
{
    public class Engine
    {
        public void Run()
        {
            string input = "";
            int counter = -1;
            string animalType = "";
            string name;
            int age;
            string gender;
            while ((input = Console.ReadLine()) != "Beast!")
            {
                counter++;
                try
                {
                    if (counter % 2 == 0)
                    {
                        animalType = input;
                    }
                    else
                    {
                        string[] animalInfo = input
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        name = animalInfo[0];
                        age = int.Parse(animalInfo[1]);
                        if (animalType == nameof(Cat))
                        {
                            gender = animalInfo[2];
                            Cat cat = new Cat(name, age, gender);
                            cat.ToString();
                            Console.WriteLine(cat.ProduceSound());
                        }
                        else if (animalType == nameof(Dog))
                        {
                            gender = animalInfo[2];
                            Dog dog = new Dog(name, age, gender);
                            dog.ToString();
                            Console.WriteLine(dog.ProduceSound());
                        }
                        else if (animalType == nameof(Frog))
                        {
                            gender = animalInfo[2];
                            Frog frog = new Frog(name, age, gender);
                            frog.ToString();
                            Console.WriteLine(frog.ProduceSound());
                        }
                        else if (animalType == nameof(Kitten))
                        {
                            Kitten kitten = new Kitten(name, age);
                            kitten.ToString();
                            Console.WriteLine(kitten.ProduceSound());
                        }
                        else if (animalType == nameof(Tomcat))
                        {
                            Tomcat tomcat = new Tomcat(name, age);
                            tomcat.ToString();
                            Console.WriteLine(tomcat.ProduceSound());
                        }
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }
        }
    }
}
