using AnimalKingdom.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Models.Classes
{
    public class Animal : IAnimal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
        public bool IsDangerous { get; set; }

        public string Name { get; }

        public string Picture { get; set; }

        public void Feed()
        {
            Console.WriteLine("Not hungry anymore");
        }
    }
}
