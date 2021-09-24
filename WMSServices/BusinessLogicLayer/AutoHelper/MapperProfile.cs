using AutoMapper;
using BusinessLogicLayer.Models;
using DataAccessLayer.Entities.AvroraWMS;

namespace BusinessLogicLayer.AutoHelper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CrTempqa, CrTempqaModel>();
        }
    }
}
