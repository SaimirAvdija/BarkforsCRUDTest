using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkforsCRUDTest.Models
{
    public class SQLVehicleRepository : IVehicleRepository
    {
        private readonly AppDbContext context;
        public SQLVehicleRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Vehicle Add(Vehicle vehicle)
        {
            context.Vehicles.Add(vehicle);
            context.SaveChanges();
            return vehicle;
        }

        public Vehicle Delete(int id)
        {
            Vehicle vehicle = context.Vehicles.Find(id);
            if(vehicle != null)
            {
                context.Vehicles.Remove(vehicle);
                context.SaveChanges();
            }
            return vehicle;
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            return context.Vehicles;
        }

        public Vehicle GetVehicle(int Id)
        {
            return context.Vehicles.Find(Id);
        }

        public Vehicle Update(Vehicle vehicleChanges)
        {
            var vehicle = context.Vehicles.Attach(vehicleChanges);
            vehicle.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return vehicleChanges;
        }
    }
}
