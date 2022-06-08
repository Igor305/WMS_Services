using AutoMapper;
using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class WMSService : IWMSService
    {
        private readonly ICrTempqaRepository _crTempqaRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public WMSService(ICrTempqaRepository crTempqaRepository, IMapper mapper, IConfiguration configuration)
        {
            _crTempqaRepository = crTempqaRepository;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<CrTempqaResponseModel> get(string key, string livrea, DateTime? dateTime, string statusBlock)
        {
            CrTempqaResponse crTempqa = new CrTempqaResponse();

            if (key != _configuration["Api:Key"])
            {
                crTempqa.Status = 1;
                crTempqa.Message = "erorr key";

                CrTempqaResponseModel tempqaResponseModel = _mapper.Map<CrTempqaResponse, CrTempqaResponseModel>(crTempqa);

                return tempqaResponseModel;
            }

            if (livrea == null)
            {
                crTempqa.Status = 1;
                crTempqa.Message = "Livrea = null";

                CrTempqaResponseModel tempqaResponseModel = _mapper.Map<CrTempqaResponse, CrTempqaResponseModel>(crTempqa);

                return tempqaResponseModel;
            }

            if (dateTime == null)
            {
                crTempqa = await _crTempqaRepository.getTemp(livrea);
            }
            else
            {
                crTempqa = await _crTempqaRepository.getTempForPeriod(livrea, dateTime, statusBlock);
            }         

            CrTempqaResponseModel crTempqaResponseModel = _mapper.Map<CrTempqaResponse, CrTempqaResponseModel>(crTempqa);

            if (crTempqaResponseModel.Message == "successfully")
            {
                crTempqaResponseModel.Status = 0;
            }

            return crTempqaResponseModel;
        }
    }    
}