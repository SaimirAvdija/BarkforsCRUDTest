using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkforsCRUDTest.Models
{
    public interface IVehicleRepository
    {
        Vehicle GetVehicle(int Id);
        IEnumerable<Vehicle> GetAllVehicles();
        Vehicle Add(Vehicle vehicle);
        Vehicle Update(Vehicle vehicleChanges);
        Vehicle Delete(int id);
    }
}
