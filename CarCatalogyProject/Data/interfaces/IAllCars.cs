using CarCatalogyProject.Models;

namespace CarCatalogyProject.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar(int carid);
    }
}
