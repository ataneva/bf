using AnimalKingdom.Models.Classes;
using AnimalKingdom.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalKingdom
{
    class Program
    {
        public static void Main(string[] args)
        {
            var animalList = PopulateList().ToList();
            
            //var dog = new Dog(new Animal("Dog"));  Dependency injection
            //animalList.Add(dog);

            var dangerousAnimals = animalList.Where(x => x.IsDangerous);

            foreach (var item in dangerousAnimals)
            {
                //if (item is IHerdAnimal) continue;
                //var isDangerous = item.IsDangerous ? "yes" : "no";
                Console.WriteLine(item.Name + " is dangerous.");
            }

            Console.ReadKey();
        }

        private static IEnumerable<IAnimal> PopulateList()
        {
            yield return new Tarantula("Tarantula");
            yield return new Shark("Shark");
            yield return new Dolphin("Dolphin");

            var dog = new Dog(new Animal("Dog"));
            yield return new Wolf("Wolf");
        }
    }
}
