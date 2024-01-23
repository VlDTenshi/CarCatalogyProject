using CarCatalogyProject.Data.interfaces;
using CarCatalogyProject.Models;
using System.Collections.Generic;

namespace CarCatalogyProject.Data.mocks
{
    public class MockTypeOfCar : ITypeOfCar
    {
        public IEnumerable<TypeOfCar> AllTypes
        {
            get
            {
                return new List<TypeOfCar>
                {
                    new TypeOfCar { typeName = "Eleсtric car", description = "modern type of vehicle"},
                    new TypeOfCar { typeName = "Oil car", description = "The vehicle with internal combustion engine"}
                };
            }
        }
    }
}
