using CarCatalogyProject.Data.interfaces;
using CarCatalogyProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogyProject.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.TypeOfCar);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavorite).Include(c => c.TypeOfCar);

        public Car getObjectCar(int carid) => appDBContent.Car.FirstOrDefault(p => p.id == carid);
        
    }
}
