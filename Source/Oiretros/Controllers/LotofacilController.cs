using Microsoft.AspNetCore.Mvc;
using Oiretros.Controllers;
using Oiretros;
using Business.Interfaces.Services;
using System.Text;

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

        [HttpGet]
        public ActionResult Get()
        {
            var result = _lotofacilService.Open("");
            StringBuilder result2 = new StringBuilder();

            foreach (var item in result)
            {
                for (var i = 2; i < 16; i++)
                {
                    var stringFormatada = item[i];
                    result2.Append(string.Format(" - " + "{0:00}", stringFormatada));
                }
                result2.Append("\n");


            }
                

            return Ok(result2.ToString());
        }
    }
}
