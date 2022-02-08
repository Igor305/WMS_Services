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

            crTempqaResponse.Status = 3;
            crTempqaResponse.Message = "successfully";

            try
            {
                // Find Livrea
                List<CrTemp> crTemps = _avroraWMSContext.CrTemps.FromSqlRaw($"Select * From [PROD_WMS_ORACLE]..[STK511PROD].[CR_TEMPQA] Where LIVREA = {livrea}"  ).ToList();

                if (crTemps.Count == 0)
                {
                    crTempqaResponse.crTempqaModels = new List<CrTemp>();
                    crTempqaResponse.Status = 3;
                    crTempqaResponse.Message = $"No products in Oracle when livrea = {livrea}";

                    return crTempqaResponse;
                }

                // Block All USSCC
                (string, List<CrTemp>) block = blockUsscc(livrea);

                if (block.Item1 != "successfully")
                {
                    crTempqaResponse.Status = 3;               
                    throw new Exception(block.Item1);
                }

                // Get USSCC FROM WMS
                if (block.Item2.Count != 0)
                {
                    crTempqaResponse.crTempqaModels = block.Item2;
                }

            }
            catch (Exception e)
            {
                crTempqaResponse.Message = e.Message;
                return crTempqaResponse;
            }

            return crTempqaResponse;
        }

        private (string, List<CrTemp>) blockUsscc(string livrea)
        {
            List<CrTemp> crTemps = new List<CrTemp>();
            string message = "successfully";

            try
            {
                crTemps = _avroraWMSContext.CrTemps.FromSqlRaw($"update [PROD_WMS_ORACLE]..[STK511PROD].[CR_TEMPQA] set BLOCK = '0' Where LIVREA = {livrea} AND (BLOCK is NUll Or BLOCK != 1) " +
                    $"SELECT * FROM [PROD_WMS_ORACLE]..[STK511PROD].[CR_TEMPQA] Where LIVREA = {livrea} AND (BLOCK is NUll Or BLOCK != 1)").ToList();

                foreach (CrTemp crTemp in crTemps)
                {
                    if(crTemp.Block != "0")
                    {
                        message = "not blocked on Oracle";
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return (message, crTemps);
        }

        public async Task<CrTempqaResponse> getTempForPeriod(string livrea, DateTime? dateTime)
        {
            CrTempqaResponse crTempqaResponse = new CrTempqaResponse();

            crTempqaResponse.Status = 3;
            crTempqaResponse.Message = "successfully";

            try
            {
                // Find Livrea
                List<CrTemp> crTemps = _avroraWMSContext.CrTemps.FromSqlRaw($"Select * From [PROD_WMS_ORACLE]..[STK511PROD].[CR_TEMPQA] Where LIVREA = {livrea} AND (CAST(DATCRE AS date) = '{dateTime.Value.Year}-{dateTime.Value.Month}-{dateTime.Value.Day}')").ToList();

                if (crTemps.Count == 0)
                {
                    crTempqaResponse.crTempqaModels = new List<CrTemp>();
                    crTempqaResponse.Status = 3;
                    crTempqaResponse.Message = $"No products in Oracle when livrea = {livrea} and DATCRE = {dateTime}";

                    return crTempqaResponse;
                }

                // Block All USSCC
                (string, List<CrTemp>) block = blockUssccForPeriod(livrea, dateTime);

                if (block.Item1 != "successfully")
                {
                    crTempqaResponse.Status = 3;
                    throw new Exception(block.Item1);
                }

                // Get USSCC FROM WMS
                if (block.Item2.Count != 0)
                {
                    crTempqaResponse.crTempqaModels = block.Item2;
                }
            }
            catch (Exception e)
            {
                crTempqaResponse.Message = e.Message;
                return crTempqaResponse;
            }
            return crTempqaResponse;
        }

        private (string, List<CrTemp>) blockUssccForPeriod(string livrea, DateTime? dateTime)
        {
            List<CrTemp> crTemps = new List<CrTemp>();
            string message = "successfully";

            try
            {
                crTemps = _avroraWMSContext.CrTemps.FromSqlRaw($"update [PROD_WMS_ORACLE]..[STK511PROD].[CR_TEMPQA] set BLOCK = '0' Where (CAST(DATCRE AS date) = '{dateTime.Value.Year}-{dateTime.Value.Month}-{dateTime.Value.Day}') AND LIVREA = {livrea} AND (BLOCK is NUll Or BLOCK != 1) " +
                    $"SELECT * FROM [PROD_WMS_ORACLE]..[STK511PROD].[CR_TEMPQA] Where (CAST(DATCRE AS date) = '{dateTime.Value.Year}-{dateTime.Value.Month}-{dateTime.Value.Day}') AND LIVREA = {livrea}  AND (BLOCK is NUll Or BLOCK != 1)").ToList();

                foreach (CrTemp crTemp in crTemps)
                {
                    if (crTemp.Block != "0")
                    {
                        message = "not blocked on Oracle";
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }

            return (message, crTemps);
        }
    }
}
