using AutoMapper;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer.Entities.AvroraWMS;
using DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
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

        public async Task<List<CrTempqaModel>> get(string livrea, DateTime? dateTime)
        {
            List<CrTempqa> crTempqas = await _crTempqaRepository.getTemp(livrea, dateTime);

            List<CrTempqaModel> crTempqaModels = _mapper.Map<List<CrTempqa>, List<CrTempqaModel>>(crTempqas);

            return crTempqaModels;
        }
    }    
}
