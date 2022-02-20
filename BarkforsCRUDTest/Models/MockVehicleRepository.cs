using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkforsCRUDTest.Models
{
public class MockVehicleRepository : IVehicleRepository
{
private List<Vehicle> _vehicleList;
public MockVehicleRepository()
{
    _vehicleList = new List<Vehicle>()
    {
        new Vehicle() {Id = 1, LicencePlateNumber = 1, ModelName = "A1", Brand = Brand.Mercedes, TypeOfFuel = TypeOfFuel.Diesel, VehicleColor = VehicleColor.Blue, VehicleEquipment = VehicleEquipment.Keyless},
        new Vehicle() {Id = 2, LicencePlateNumber = 2, ModelName = "B2", Brand = Brand.BMW, TypeOfFuel = TypeOfFuel.Gasoline, VehicleColor = VehicleColor.Red, VehicleEquipment = VehicleEquipment.None},
        new Vehicle() {Id = 3, LicencePlateNumber = 3, ModelName = "C3", Brand = Brand.Tesla, TypeOfFuel = TypeOfFuel.Electric, VehicleColor = VehicleColor.White, VehicleEquipment = VehicleEquipment.Sportseats}
    };
}

    public Vehicle Add(Vehicle vehicle)
    {
            vehicle.Id = _vehicleList.Max(v => v.Id) + 1;
            _vehicleList.Add(vehicle);
            return vehicle;
    }

        public Vehicle Delete(int id)
        {
            Vehicle vehicle = _vehicleList.FirstOrDefault(v => v.Id == id);
            if(vehicle != null)
            {
                _vehicleList.Remove(vehicle);
            }
            return vehicle;
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
           return _vehicleList;
        }

public Vehicle GetVehicle(int Id)
{
    return _vehicleList.FirstOrDefault(v => v.Id == Id);
}

        public Vehicle Update(Vehicle vehicleChanges)
        {
            Vehicle vehicle = _vehicleList.FirstOrDefault(v => v.Id == vehicleChanges.Id);
            if (vehicle != null)
            {
                vehicle.LicencePlateNumber = vehicleChanges.LicencePlateNumber;
                vehicle.ModelName = vehicleChanges.ModelName;
                vehicle.Brand = vehicleChanges.Brand;
                vehicle.TypeOfFuel = vehicleChanges.TypeOfFuel;
                vehicle.VehicleColor = vehicleChanges.VehicleColor;
                vehicle.VehicleEquipment = vehicleChanges.VehicleEquipment;
            }
            return vehicle;
        }
    }
}
