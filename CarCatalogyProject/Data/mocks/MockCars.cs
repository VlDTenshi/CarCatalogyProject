using CarCatalogyProject.Data.interfaces;
using CarCatalogyProject.Models;
using System;
using System.Collections.Generic;

namespace CarCatalogyProject.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ITypeOfCar _typeOfCars = new MockTypeOfCar();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { 
                        name = "Tesla", 
                        shortDesc = "Electric car", 
                        longDesc = "Tesla is an innovative automaker renowned for its electric " +
                        "vehicles that blend cutting-edge technology, high performance, " +
                        "and environmental sustainability. Tesla cars feature powerful electric motors, " +
                        "autopilot capabilities for autonomous driving, and advanced safety systems, " +
                        "positioning them as leaders in the electric vehicle industry.", 
                        img = "/img/car4.jpg", 
                        price = 45000, 
                        isFavorite = true, 
                        available = true, 
                        TypeOfCar = _typeOfCars.AllTypes.First()
                    },
                    new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Compact hatchback",
                        longDesc = "The Ford Fiesta is a stylish and economical compact car known for its excellent maneuverability " +
                        "and fuel efficiency. With a range of technological features, comfortable interior, " +
                        "and reliable engine, the Ford Fiesta is a popular choice for urban and everyday driving.",
                        img = "/img/car3.png",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        TypeOfCar = _typeOfCars.AllTypes.Last()
                    },
                    new Car {
                        name = "Mercedes E-Class",
                        shortDesc = "Premium sedan",
                        longDesc = "The Mercedes E-Class is an exquisite and luxurious sedan that combines outstanding performance, " +
                        "cutting-edge technology, and sophisticated design. With a premium interior, innovative safety systems, " +
                        "and powerful engines, the Mercedes E-Class offers a level of comfort " +
                        "and elegance synonymous with high-end automobiles.",
                        img = "/img/car2.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        TypeOfCar = _typeOfCars.AllTypes.Last()
                    },
                    new Car {
                        name = "Nissan Leaf",
                        shortDesc = "Electric hatchback",
                        longDesc = "The Nissan Leaf is a pioneering electric hatchback known for its efficiency and environmental focus." +
                        " With impressive range capabilities, modern safety technologies, " +
                        "and a comfortable interior, the Nissan Leaf has showcased the excellence of electric vehicles in the realm of sustainable mobility.",
                        img = "/img/car1.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        TypeOfCar = _typeOfCars.AllTypes.First()
                    }
                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
