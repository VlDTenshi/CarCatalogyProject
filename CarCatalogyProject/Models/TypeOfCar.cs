using System.Collections.Generic;

namespace CarCatalogyProject.Models
{
    public class TypeOfCar
    {
        public int id {  get; set; }
        public string typeName { get; set; }
        public string description { get; set; }
        public List<Car> cars { get; set;}
    }
}
