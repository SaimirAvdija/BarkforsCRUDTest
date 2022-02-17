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
        public string Brand { get; set; }
        public string TypeOfFuel { get; set; }
        public string Color { get; set; }
        public string VehicleEquipment { get; set; }
    }
}
