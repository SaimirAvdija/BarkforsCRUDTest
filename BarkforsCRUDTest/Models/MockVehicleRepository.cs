using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkforsCRUDTest.Models
{
    public class MockVehicleRepository : IVehicleRepository
    {
        private List<VehicleEquipment> _vehicleEquipment;
        private List<Vehicle> _vehicleList;
        public MockVehicleRepository()
        {
            _vehicleList = new List<Vehicle>()
            {
                new Vehicle() {Id = 1, LicencePlateNumber = 1, ModelName = "A1", Brand = Brand.Mercedes, TypeOfFuel = TypeOfFuel.Diesel, VehicleColor = VehicleColor.Blue, VehicleEquipment = VehicleEquipment.Family},
                new Vehicle() {Id = 2, LicencePlateNumber = 2, ModelName = "B2", Brand = Brand.BMW, TypeOfFuel = TypeOfFuel.Gasoline, VehicleColor = VehicleColor.Red, VehicleEquipment = VehicleEquipment.None},
                new Vehicle() {Id = 3, LicencePlateNumber = 3, ModelName = "C3", Brand = Brand.Tesla, TypeOfFuel = TypeOfFuel.Electric, VehicleColor = VehicleColor.White, VehicleEquipment = VehicleEquipment.Seatwarmer}
            };
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            return _vehicleList;
        }

        public Vehicle GetVehicle(int Id)
        {
            return _vehicleList.FirstOrDefault(v => v.Id == Id);
        }
    }
}
