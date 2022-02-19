using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkforsCRUDTest.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int LicencePlateNumber { get; set; }
        public string ModelName { get; set; }
        public Brand Brand { get; set; }
        public TypeOfFuel TypeOfFuel { get; set; }
        public VehicleColor VehicleColor { get; set; }
        public VehicleEquipment VehicleEquipment { get; set; }
    }
}
