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
            var jogos = ConvertListTojogoLotofacil(result);

            return Ok(jogos.JogosLotofacil);
        }

        [HttpGet("GetByNumber")]
        public ActionResult GetAll()
        {
            var result = _lotofacilService.Open("");
            var jogos = ConvertListTojogoLotofacil(result);


            return Ok(jogos.JogosLotofacil);
        }



        private Jogos ConvertListTojogoLotofacil(List<List<object>> result)
        {
            Jogos jogos = new Jogos();

            result.Remove(result[0]);

            foreach (var item in result)
            {
                JogoLotofacil jogoLotofacil = new JogoLotofacil();
                jogoLotofacil.Concurso = Convert.ToInt32( item[0]);

                for (var i = 2; i < 17; i++)
                {
                    var value = Convert.ToByte(item[i]);
                    jogoLotofacil.Numeros.Add(value);

                }
                jogos.JogosLotofacil.Add(jogoLotofacil);
            }

            return jogos;
        }
    }
}
