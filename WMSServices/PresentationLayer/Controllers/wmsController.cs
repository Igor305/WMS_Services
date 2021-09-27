using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class wmsController : ControllerBase
    {
        private IWMSService _WMSService;

        public wmsController(IWMSService wMSService)
        {
            _WMSService = wMSService;
        }

        /// <summary>
        /// WMSss
        /// </summary>
        /// <param name="livrea"></param>
        /// <param name="dateTime"></param>
        /// <remarks>
        /// Sample request:
        ///
        ///     https://localhost:44351/api/wms?livrea=609
        ///
        /// </remarks>
        [HttpGet]
        public async Task<CrTempqaResponseModel> getTempqaModels([FromQuery]string livrea, [FromQuery]DateTime? dateTime)
        {

            CrTempqaResponseModel crTempqaResponseModel = await _WMSService.get(livrea, dateTime);

            return crTempqaResponseModel;
        }
    }
}
