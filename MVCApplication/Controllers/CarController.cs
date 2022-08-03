
using BusinessLogic.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult GetAllCar()
        {
            return Ok(_carService.GetCars());
        }

        [HttpPost]
        public IActionResult AddCar()
        {
            _carService.AddAllCars();
            return Ok();
        }
    }
}

