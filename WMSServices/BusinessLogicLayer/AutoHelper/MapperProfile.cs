using AutoMapper;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Models.Response;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.AvroraWMS;

namespace BusinessLogicLayer.AutoHelper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CrTempqaResponse, CrTempqaResponseModel>();
            CreateMap<CrTempqa, CrTempqaModel>();
            CreateMap<DataAccessLayer.Entities.ResultDescription, Models.ResultDescription>();
        }
    }
}
