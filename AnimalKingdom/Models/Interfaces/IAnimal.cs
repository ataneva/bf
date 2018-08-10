
namespace AnimalKingdom.Models.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        string Picture { get; set; }
        bool IsDangerous { get; }

        void Feed();

    }
}
