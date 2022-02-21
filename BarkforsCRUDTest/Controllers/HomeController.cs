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
                Vehicle = _vehicleRepository.GetVehicle(id ?? 1),
                PageTitle = "Vehicle Details"
            };
            return View(homeDetailsViewModel);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Vehicle vehicle = _vehicleRepository.GetVehicle(id);
            VehicleEditViewModel vehicleEditViewModel = new VehicleEditViewModel
            {
                Id = vehicle.Id,
                LicencePlateNumber = vehicle.LicencePlateNumber,
                ModelName = vehicle.ModelName,
                Brand = vehicle.Brand,
                TypeOfFuel = vehicle.TypeOfFuel,
                VehicleColor = vehicle.VehicleColor,
                VehicleEquipment = vehicle.VehicleEquipment,
            };
            return View(vehicleEditViewModel);
        }
        [HttpPost]
        public IActionResult Edit(VehicleEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Vehicle vehicle = _vehicleRepository.GetVehicle(model.Id);
                vehicle.LicencePlateNumber = model.LicencePlateNumber;
                vehicle.ModelName = model.ModelName;
                vehicle.Brand = model.Brand;
                vehicle.TypeOfFuel = model.TypeOfFuel;
                vehicle.VehicleColor = model.VehicleColor;
                vehicle.VehicleEquipment = model.VehicleEquipment;
                _vehicleRepository.Update(vehicle);
                return RedirectToAction("index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Create(VehicleCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Vehicle newVehicle = new Vehicle
                {
                    LicencePlateNumber = model.LicencePlateNumber,
                    ModelName = model.ModelName,
                    Brand = model.Brand,
                    TypeOfFuel = model.TypeOfFuel,
                    VehicleColor = model.VehicleColor,
                    VehicleEquipment = model.VehicleEquipment,
                };
                _vehicleRepository.Add(newVehicle);
                return RedirectToAction("details", new { id = newVehicle.Id });
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            Vehicle deleteVehicle = _vehicleRepository.Delete(id);
            return RedirectToAction("index");
        }
        public IActionResult Filter(string searchBy, string search)
        {
            var vehicleList = _vehicleRepository.GetAllVehicles();
            if (searchBy == "LicencePlateNumber")
            {
                return View(vehicleList.Where(x => x.LicencePlateNumber.ToString() == search));
            }
            else
            {
                return View(vehicleList.Where(x => x.ModelName == search.ToUpper()));
            }
        }
    }

}