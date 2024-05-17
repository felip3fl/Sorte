using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Jogos
    {
        public Jogos()
        {
            JogosLotofacil = new List<JogoLotofacil>();
        }
        public List<JogoLotofacil> JogosLotofacil { get; set; }
    }
}
