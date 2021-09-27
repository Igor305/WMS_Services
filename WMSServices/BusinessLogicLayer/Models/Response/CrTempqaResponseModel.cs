using System.Collections.Generic;

namespace BusinessLogicLayer.Models.Response
{
    public class CrTempqaResponseModel
    {
        public List<CrTempqaModel> crTempqaModels { get; set; }
        public ResultDescription resultDescription { get; set; }

        public CrTempqaResponseModel()
        {
            crTempqaModels = new List<CrTempqaModel>();
            resultDescription = new ResultDescription();
        }
    }
}
