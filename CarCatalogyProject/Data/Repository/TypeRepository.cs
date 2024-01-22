using CarCatalogyProject.Data.interfaces;
using CarCatalogyProject.Models;

namespace CarCatalogyProject.Data.Repository
{
    public class TypeRepository : ITypeOfCar
    {
        private readonly AppDBContent appDBContent;

        public TypeRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<TypeOfCar> AllTypes => appDBContent.TypeOfCar;
    }
}
