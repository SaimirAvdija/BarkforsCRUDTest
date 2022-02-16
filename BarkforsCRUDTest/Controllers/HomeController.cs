using BarkforsCRUDTest.Models;
using BarkforsCRUDTest.ViewModels;
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
        public ViewResult Index()
        {
            var model = _vehicleRepository.GetAllVehicles();
            return View(model);
        }
        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Vehicle = _vehicleRepository.GetVehicle(1),
                PageTitle = "Vehicle Details"
            };
            return View(homeDetailsViewModel);
        }
    }
}
