using Microsoft.AspNetCore.Mvc;
using Oiretros.Controllers;
using Oiretros;
using Business.Interfaces.Services;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LotofacilController : Controller
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ILotofacilService _lotofacilService;

        public LotofacilController(ILogger<WeatherForecastController> logger, ILotofacilService lotofacilService)
        {
            _logger = logger;
            _lotofacilService = lotofacilService;
        }

        [HttpGet(Name = "GetGames")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
            })
            .ToArray();
        }
    }
}
