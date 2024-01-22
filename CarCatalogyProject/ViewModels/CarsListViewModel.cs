using CarCatalogyProject.Models;
using System.Collections.Generic;

namespace CarCatalogyProject.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars {  get; set; }

        public string carType { get; set; }
    }
}
