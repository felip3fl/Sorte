using Microsoft.AspNetCore.Mvc;
using Oiretros;
using Business.Interfaces.Services;
using System.Text;
using Business.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LotofacilController : Controller
    {

        private readonly ILotofacilService _lotofacilService;

        public LotofacilController(ILotofacilService lotofacilService)
        {
            _lotofacilService = lotofacilService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var result = _lotofacilService.Open("");
            var jogoLotofacil = ConvertListTojogoLotofacil(result);



            return Ok(jogoLotofacil);
        }

        private JogoLotofacil ConvertListTojogoLotofacil(List<List<object>> result)
        {
            StringBuilder result2 = new StringBuilder();
            JogoLotofacil jogoLotofacil = new JogoLotofacil();

            foreach (var item in result)
            {
                for (var i = 2; i < 16; i++)
                {
                    switch (item[i])
                    {
                        case 1:
                            jogoLotofacil.NumberOne = true;
                            break;

                        case 2:
                            jogoLotofacil.NumberTwo = true;
                            break;

                        case 3:
                            jogoLotofacil.NumberThree = true;
                            break;
                        case 4:
                            jogoLotofacil.NumberFour = true;
                            break;
                        case 5:
                            jogoLotofacil.NumberFive = true;
                            break;
                        case 6:
                            jogoLotofacil.NumberSix = true;
                            break;
                        case 7:
                            jogoLotofacil.NumberSeven = true;
                            break;
                        case 8:
                            jogoLotofacil.NumberEight = true;
                            break;
                        case 9:
                            jogoLotofacil.NumberNine = true;
                            break;
                        case 10:
                            jogoLotofacil.NumberTen = true;
                            break;
                        case 11:
                            jogoLotofacil.NumberEleven = true;
                            break;
                        case 12:
                            jogoLotofacil.NumberTwelve = true;
                            break;
                        case 13:
                            jogoLotofacil.NumberThirteen = true;
                            break;
                        case 14:
                            jogoLotofacil.NumberFourteen = true;
                            break;
                        case 15:
                            jogoLotofacil.NumberFifteen = true;
                            break;
                        case 16:
                            jogoLotofacil.NumberSixteen = true;
                            break;
                        case 17:
                            jogoLotofacil.NumberSeventeen = true;
                            break;
                        case 18:
                            jogoLotofacil.NumberEighteen = true;
                            break;
                        case 19:
                            jogoLotofacil.NumberNineteen = true;
                            break;
                        case 20:
                            jogoLotofacil.NumberTwenty = true;
                            break;
                        case 21:
                            jogoLotofacil.NumberTwentyOne = true;
                            break;
                        case 22:
                            jogoLotofacil.NumberTwentyTwo = true;
                            break;
                        case 23:
                            jogoLotofacil.NumberTwentyThree = true;
                            break;
                        case 24:
                            jogoLotofacil.NumberTwentyFour = true;
                            break;
                        case 25:
                            jogoLotofacil.NumberTwentyFive = true;
                            break;

                    }

                }
                result2.Append("\n");

            }

            return jogoLotofacil;
        }
    }
}
