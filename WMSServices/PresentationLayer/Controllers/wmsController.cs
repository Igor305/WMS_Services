using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class wmsController : ControllerBase
    {
        private readonly IWMSService _WMSService;

        public wmsController(IWMSService wMSService)
        {
            _WMSService = wMSService;
        }

        [HttpGet]
        public async Task<List<CrTempqaModel>> getTempqaModels([FromQuery]string livrea, [FromQuery]DateTime? dateTime)
        {

            List<CrTempqaModel> crTempqaModels = await _WMSService.get(livrea, dateTime);

            return crTempqaModels;
        }
    }
}
