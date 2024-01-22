using CarCatalogyProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CarCatalogyProject.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<TypeOfCar> TypeOfCar { get; set; }
    }
}
