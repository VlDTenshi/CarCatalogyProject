using CarCatalogyProject.Data.interfaces;
using CarCatalogyProject.Models;
using Microsoft.Identity.Client;

namespace CarCatalogyProject.Data
{
    public class DBObject
    {
        public static async Task Initial(AppDBContent content)
        {
            
            
            if (!content.TypeOfCar.Any())
            
                content.TypeOfCar.AddRange(Types.Select(c => c.Value));


            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
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
                        TypeOfCar = Types["Eleсtric_car"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Compact hatchback",
                        longDesc = "The Ford Fiesta is a stylish and economical compact car known for its excellent maneuverability " +
                        "and fuel efficiency. With a range of technological features, comfortable interior, " +
                        "and reliable engine, the Ford Fiesta is a popular choice for urban and everyday driving.",
                        img = "/img/car3.png",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        TypeOfCar = Types["Oil_car"]
                    },
                    new Car
                    {
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
                        TypeOfCar = Types["Oil_car"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Electric hatchback",
                        longDesc = "The Nissan Leaf is a pioneering electric hatchback known for its efficiency and environmental focus." +
                        " With impressive range capabilities, modern safety technologies, " +
                        "and a comfortable interior, the Nissan Leaf has showcased the excellence of electric vehicles in the realm of sustainable mobility.",
                        img = "/img/car1.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        TypeOfCar = Types["Eleсtric_car"]
                    }
                    );
            }

            content.SaveChanges();

        }
        private static Dictionary<string, TypeOfCar> type;
        public static Dictionary<string, TypeOfCar> Types
        {
            get
            {
                if(type == null) 
                {
                    var list = new TypeOfCar[]
                    {
                        new TypeOfCar { typeName = "Eleсtric_car", description = "modern type of vehicle"},
                        new TypeOfCar { typeName = "Oil_car", description = "The vehicle with internal combustion engine"}
                    };
                    type = new Dictionary<string, TypeOfCar>();
                    foreach (TypeOfCar tp in list)
                        type.Add(tp.typeName, tp);
                }
                return type;
            }
        }
    }
}
