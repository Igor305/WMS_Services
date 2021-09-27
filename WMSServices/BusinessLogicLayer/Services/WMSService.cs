using AutoMapper;
using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class WMSService : IWMSService
    {
        private readonly ICrTempqaRepository _crTempqaRepository;
        private readonly IMapper _mapper;

        public WMSService(ICrTempqaRepository crTempqaRepository, IMapper mapper)
        {
            _crTempqaRepository = crTempqaRepository;
            _mapper = mapper;
        }

        public async Task<CrTempqaResponseModel> get(string livrea, DateTime? dateTime)
        {
            CrTempqaResponse crTempqa = new CrTempqaResponse();

            if (livrea == null)
            {
                crTempqa.resultDescription.Status = 1;
                crTempqa.resultDescription.Message = "Livrea = null";         
            }
            else
            {
                if (dateTime == null)
                {
                    crTempqa = await _crTempqaRepository.getTemp(livrea);
                }
                else
                {
                    crTempqa = await _crTempqaRepository.getTempForPeriod(livrea, dateTime);
                }
            }

            CrTempqaResponseModel crTempqaResponseModel = _mapper.Map<CrTempqaResponse,CrTempqaResponseModel>(crTempqa);

            if (crTempqaResponseModel.resultDescription.Message == "successfully")
            {
                crTempqaResponseModel.resultDescription.Status = 0;
            }

            return crTempqaResponseModel;
        }
    }    
}