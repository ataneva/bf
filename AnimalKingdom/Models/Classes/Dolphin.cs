using AnimalKingdom.Models.Interfaces;
using System; 

namespace AnimalKingdom.Models.Classes
{
    public class Dolphin : IFish, IHerdAnimal, IMarineAnimal
    {
        public Dolphin(string name)
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
