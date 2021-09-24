using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IWMSService
    {
        public Task<List<CrTempqaModel>> get(string livrea, DateTime? dateTime);
    }
}
