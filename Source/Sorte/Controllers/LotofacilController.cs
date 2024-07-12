using Microsoft.AspNetCore.Mvc;
using Sorte;
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
            _lotofacilService.Load("");
        }

        [HttpGet]
        public ActionResult Get()
        {
            var jogos = ConvertListTojogoLotofacil(_lotofacilService.GetList());

            return Ok(jogos.JogosLotofacil);
        }

        [HttpGet("GetByNumber")]
        public ActionResult GetAll(byte number)
        {
            var jogos = ConvertListTojogoLotofacil(_lotofacilService.GetList());


            return Ok(jogos.JogosLotofacil.Where(x => x.Numeros.Contains(number)));
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
