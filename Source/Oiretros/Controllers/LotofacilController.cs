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
        public ActionResult Get()
        {
            var result = _lotofacilService.Open("");

            return Ok(result);
        }
    }
}
