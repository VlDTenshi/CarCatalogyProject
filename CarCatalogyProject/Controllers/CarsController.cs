using CarCatalogyProject.Data.interfaces;
using CarCatalogyProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalogyProject.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ITypeOfCar _allTypes;

        public CarsController(IAllCars allCars, ITypeOfCar allTypes)
        {
            _allCars = allCars;
            _allTypes = allTypes;
        }

        public ViewResult List()
        {
            ViewBag.Title = "The page with vehicles";
            CarsListViewModel model = new CarsListViewModel();
            model.allCars = _allCars.Cars;
            model.carType = "Vehicles";
            //var cars = _allCars.Cars;
            return View(model);
        }
    }
}
