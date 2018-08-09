
namespace AnimalKingdom.Models.Interfaces
{
    interface IAnimal
    {
        string Name { get; }
        string Picture { get; set; }
        bool IsDangerous { get; }

        void Feed();

    }
}
