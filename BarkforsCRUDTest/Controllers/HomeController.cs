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
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Vehicle = _vehicleRepository.GetVehicle(id??1),
                PageTitle = "Vehicle Details"
            };
            return View(homeDetailsViewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        public ViewResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                Vehicle newVehicle = _vehicleRepository.Add(vehicle);
                return RedirectToAction("details", new { id = newVehicle.Id });
            }
            return View();
        }
    }
}
