using BarkforsCRUDTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkforsCRUDTest.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Vehicle Vehicle { get; set; }
        public string PageTitle { get; set; }
        public int LicencePlateNumber { get; set; }
        public string ModelName { get; set; }
        public Brand Brand { get; set; }
        public TypeOfFuel TypeOfFuel { get; set; }
        public VehicleEquipment VehicleEquipment { get; set; }
        public VehicleColor VehicleColor { get; set; }
    }
}
