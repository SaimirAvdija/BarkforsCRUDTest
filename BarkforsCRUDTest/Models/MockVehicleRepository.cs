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
                new Vehicle() {Id = 1, LicencePlateNumber = 1, ModelName = "A1", Brand = "Mercedes", TypeOfFuel = "Diesel", Color = "Blue"},
                new Vehicle() {Id = 2, LicencePlateNumber = 2, ModelName = "B2", Brand = "KIA", TypeOfFuel = "Gasoline", Color = "Orange"},
                new Vehicle() {Id = 3, LicencePlateNumber = 3, ModelName = "C3", Brand = "Tesla", TypeOfFuel = "Electric", Color = "White"}
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
