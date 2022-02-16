using BarkforsCRUDTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkforsCRUDTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVehicleRepository _vehicleRepository;

        public HomeController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        public string Index()
        {
            return _vehicleRepository.GetVehicle(1).ModelName;
        }
        public ViewResult Details()
        {
            Vehicle model = _vehicleRepository.GetVehicle(1);
            return View(model);
        }
    }
}
