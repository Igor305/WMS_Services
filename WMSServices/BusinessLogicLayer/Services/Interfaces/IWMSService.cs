using BusinessLogicLayer.Models.Response;
using System;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IWMSService
    {
        public Task<CrTempqaResponseModel> get(string key, string livrea, DateTime? dateTime);
    }
}
