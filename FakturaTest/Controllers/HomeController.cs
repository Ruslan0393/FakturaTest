using FakturaTest.Service.DTOs;
using FakturaTest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FakturaTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarService carService;

        public HomeController(ICarService carService)
        {
            this.carService = carService;
        }


        public IActionResult Index(string max, string min, string sort)
        {
            ViewCarDto cars = new ViewCarDto();
            cars.Cars = carService.GetAll(max:max, min:min, sort:sort);
            return View(cars);
        }


        [HttpPost]
        public IActionResult Delete(long id)
        {
            carService.Delete(p => p.Id == id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AddCarDto carDto)
        {
            if (ModelState.IsValid)
            {
                carService.CreateAsync(carDto);
                return RedirectToAction("Index");
            }
            return View();
        }

        
    }
}
