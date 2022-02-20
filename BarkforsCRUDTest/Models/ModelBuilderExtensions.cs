using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkforsCRUDTest.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle
                {
                    Id = 1,
                    LicencePlateNumber = 1,
                    ModelName = "A1",
                    Brand = Brand.Mercedes,
                    TypeOfFuel = TypeOfFuel.Diesel,
                    VehicleColor = VehicleColor.Blue,
                    VehicleEquipment = VehicleEquipment.Sport
                }
                );
        }
    }
}
