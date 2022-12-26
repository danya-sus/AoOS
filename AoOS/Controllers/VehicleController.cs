using AoOS.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace AoOS.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class VehicleController : ControllerBase
    {
        private IVehicleRepository _repository;
        private ILogger _logger;

        public VehicleController(IVehicleRepository repository, ILogger<VehicleController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("home")]
        public IActionResult Home()
        {
            return Ok("Its alive!");
        }

        [HttpGet("vehicles")]
        public IActionResult GetVehicles()
        {
            _logger.LogInformation("GET VEHICLES ...");
            return Ok(_repository.GetAll());
        }

        [HttpGet("vehicle/{id}")]
        public IActionResult GetVehicle(string id)
        {
            return Ok(_repository.Get(id));
        }
    }
}
