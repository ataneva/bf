using AnimalKingdom.Models.Interfaces;
using System;  

namespace AnimalKingdom.Models.Classes
{
    public class Dog
    {
        private IAnimal _animal;

        public Dog(IAnimal animal)
        {
            this._animal = animal;
        }
        public bool IsDangerous { get; } = false;

        public string Name { get; }

        public string Picture { get; set; }

        public void Feed()
        {
            Console.WriteLine("Dog is feeded");
            this._animal.Feed();
        }
    }
}
