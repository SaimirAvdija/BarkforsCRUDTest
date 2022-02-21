using BarkforsCRUDTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarkforsCRUDTest.ViewModels
{
    public class VehicleCreateViewModel
    {
        public int LicencePlateNumber { get; set; }
        [Required]
        public string ModelName { get; set; }
        public Brand Brand { get; set; }
        public TypeOfFuel TypeOfFuel { get; set; }
        public VehicleColor VehicleColor { get; set; }
        public VehicleEquipment VehicleEquipment { get; set; }
    }
}

