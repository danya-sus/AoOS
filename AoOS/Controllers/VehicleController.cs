using AoOS.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace AoOS.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class VehicleController : ControllerBase
    {
        private HttpClient _client;
        private IVehicleRepository _repository;

        public VehicleController(IVehicleRepository repository)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Environment.GetEnvironmentVariable("URI_ENV") ?? string.Empty);
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            _repository = repository;
        }

        [HttpGet("vehicles")]
        public IActionResult GetVehicles()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("vehicle/{id}")]
        public IActionResult GetVehicle(string id)
        {
            return Ok(_repository.Get(id));
        }
    }
}
