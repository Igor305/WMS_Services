using DataAccessLayer.AppContext;
using DataAccessLayer.Entities.AvroraWMS;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class CrTempqaRepository : ICrTempqaRepository
    {
        private AvroraWMSContext _avroraWMSContext;

        public CrTempqaRepository(AvroraWMSContext avroraWMSContext)
        {
            _avroraWMSContext = avroraWMSContext;
        }

        public async Task<List<CrTempqa>> getTemp(string livrea, DateTime? dateTime)
        {
            List<CrTempqa> crTempqaRepositories = await _avroraWMSContext.CrTempqas.Where(x => x.Livrea == livrea && x.Datcre.Value.Date == dateTime.Value.Date).ToListAsync();

            blockUsscc(livrea, dateTime);

            return crTempqaRepositories;
        }

        private void blockUsscc(string livrea, DateTime? dateTime)
        {
            try
            {
                var r = _avroraWMSContext.CrTempqas.FromSqlRaw($"update [WMS_ORACLE]..[STK511TRN].[CR_TEMPQA] set BLOCK = '0' Where (CAST(DATCRE AS date) = '{dateTime.Value.Year}-{dateTime.Value.Month}-{dateTime.Value.Day}') AND USSCC In(SELECT USSCC FROM CR_TEMPQA Where LIVREA = {livrea})").ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
