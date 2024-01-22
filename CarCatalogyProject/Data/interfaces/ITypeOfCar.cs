using CarCatalogyProject.Models;

namespace CarCatalogyProject.Data.interfaces
{
    public interface ITypeOfCar
    {
        IEnumerable<TypeOfCar> AllTypes { get; }
    }
}
