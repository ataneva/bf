using AnimalKingdom.Models.Interfaces;
using System;

namespace AnimalKingdom.Models.Classes
{
    public class Shark : IFish, IPredator
    {
        public Shark(string name)
        {
            this.Name = name;
        }
        public bool IsDangerous { get; } = true;

        public string Name { get; }

        public string Picture { get; set; }

        public void Feed()
        {
            throw new NotImplementedException();
        }
    }
}
