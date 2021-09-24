using DataAccessLayer.Entities.AvroraWMS;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface ICrTempqaRepository
    {
        public Task<List<CrTempqa>> getTemp(string livrea, DateTime? dateTime);
    }
}
