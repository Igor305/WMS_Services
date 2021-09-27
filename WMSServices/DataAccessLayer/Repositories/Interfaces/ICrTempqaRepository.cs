using DataAccessLayer.Entities;
using System;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface ICrTempqaRepository
    {
        public Task<CrTempqaResponse> getTemp(string livrea);
        public Task<CrTempqaResponse> getTempForPeriod(string livrea, DateTime? dateTime);
    }
}
