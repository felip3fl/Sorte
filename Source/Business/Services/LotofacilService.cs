using Business.Interfaces.Infra;
using Business.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class LotofacilService : ILotofacilService
    {
        private readonly IExcelFile _excelFile;

        public LotofacilService(IExcelFile excelFile)
        {
            _excelFile = excelFile;
        }

        public List<List<object>> Open(string filePath)
        {
            var result = _excelFile.Open("C:\\Users\\felip\\Source\\FL_OIRETROS\\Material\\Lotofácil24032024.xlsx");
            return result;
        }
    }
}
