using DataAccessLayer.AppContext;
using DataAccessLayer.Entities;
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

        public async Task<CrTempqaResponse> getTemp(string livrea)
        {
            CrTempqaResponse crTempqaResponse = new CrTempqaResponse();

            crTempqaResponse.Status = 2;
            crTempqaResponse.Message = "successfully";

            try
            {
                crTempqaResponse.crTempqaModels = await _avroraWMSContext.CrTempqas.Where(x => x.Livrea == livrea).ToListAsync();

                string message = blockUsscc(livrea);

                if (message != "successfully")
                {
                    crTempqaResponse.Status = 3;               
                    throw new Exception(message);
                }
            }
            catch (Exception e)
            {
                crTempqaResponse.Message = e.Message;
                return crTempqaResponse;
            }
            return crTempqaResponse;
        }

        private string blockUsscc(string livrea)
        {
            string message = "successfully";

            try
            {
                List<CrTemp> crTemps = _avroraWMSContext.CrTemps.FromSqlRaw($"SELECT * FROM[WMS_ORACLE]..[STK511TRN].[CR_TEMPQA] update [WMS_ORACLE]..[STK511TRN].[CR_TEMPQA] set BLOCK = '0' Where USSCC In(SELECT USSCC FROM CR_TEMPQA Where LIVREA = {livrea})").ToList();
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return message;
        }

        public async Task<CrTempqaResponse> getTempForPeriod(string livrea, DateTime? dateTime)
        {
            CrTempqaResponse crTempqaResponse = new CrTempqaResponse();

            crTempqaResponse.Status = 2;
            crTempqaResponse.Message = "successfully";

            try
            {
                crTempqaResponse.crTempqaModels = await _avroraWMSContext.CrTempqas.Where(x => x.Livrea == livrea && x.Datcre.Value.Date == dateTime.Value.Date).ToListAsync();

                string message = blockUssccForPeriod(livrea, dateTime);

                if (message != "successfully")
                {
                    crTempqaResponse.Status = 3;
                    throw new Exception(message);
                }
            }
            catch (Exception e)
            {
                crTempqaResponse.Message = e.Message;
                return crTempqaResponse;
            }
            return crTempqaResponse;
        }

        private string blockUssccForPeriod(string livrea, DateTime? dateTime)
        {
            string message = "successfully";

            try
            {
                List<CrTemp> crTemps = _avroraWMSContext.CrTemps.FromSqlRaw($"SELECT * FROM[WMS_ORACLE]..[STK511TRN].[CR_TEMPQA] update [WMS_ORACLE]..[STK511TRN].[CR_TEMPQA] set BLOCK = '0' Where (CAST(DATCRE AS date) = '{dateTime.Value.Year}-{dateTime.Value.Month}-{dateTime.Value.Day}') AND USSCC In(SELECT USSCC FROM CR_TEMPQA Where LIVREA = {livrea})").ToList();
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return message;
        }
    }
}
