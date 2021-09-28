using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class lotController : ControllerBase
    {
        private IWMSService _WMSService;

        public lotController(IWMSService wMSService)
        {
            _WMSService = wMSService;
        }

        /// <summary>
        /// Перелік товарів за лотом
        /// </summary>
        /// <param name="livrea">Код одержувача лоту</param>
        /// <param name="dateTime">Дата створення запису</param>
        /// <remarks>
        /// Sample request:
        ///
        ///     http://qawms.avrora.lan/api/lot?livrea=609
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
