﻿namespace CarCatalogyProject.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img {  get; set; }
        public ushort price { get; set; }
        public bool isFavorite { get; set; }
        public bool available { get; set; }
        public int typeID { get; set; }
        public virtual TypeOfCar TypeOfCar { get; set; }
    }
}
