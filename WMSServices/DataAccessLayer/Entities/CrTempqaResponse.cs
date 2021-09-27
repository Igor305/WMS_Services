using DataAccessLayer.Entities.AvroraWMS;
using System.Collections.Generic;

namespace DataAccessLayer.Entities
{
    public class CrTempqaResponse
    {
        public List<CrTempqa> crTempqaModels { get; set; }
        public ResultDescription resultDescription { get; set; }

        public CrTempqaResponse()
        {
            crTempqaModels = new List<CrTempqa>();
            resultDescription = new ResultDescription();
        }
    }
}
