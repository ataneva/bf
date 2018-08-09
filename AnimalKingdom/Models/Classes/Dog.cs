using AnimalKingdom.Models.Interfaces;
using System;  

namespace AnimalKingdom.Models.Classes
{
    public class Dog  : IPet, IMammal
    {
        public Dog(string name)
        {
            this.Name = name;
        }
        public bool IsDangerous { get; } = false;

        public string Name { get; }

        public string Picture { get; set; }

        public void Feed()
        {
            throw new NotImplementedException();
        }
    }
}
