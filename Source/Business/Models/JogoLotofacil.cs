using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class JogoLotofacil
    {
        public JogoLotofacil() 
        {
            Numeros = new List<byte>();
        }

        public int Concurso { get; set; }
        public List<byte> Numeros { get; set; }
        
    }
}
