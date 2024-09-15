﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.Services
{
    public interface ILotofacilService
    {
        void Load(string filePath);
        List<List<object>> GetList();
    }
}
