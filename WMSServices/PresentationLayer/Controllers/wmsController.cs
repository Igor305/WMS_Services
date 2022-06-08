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
        private readonly IWMSService _WMSService;

        public lotController(IWMSService wMSService)
        {
            _WMSService = wMSService;
        }

        /// <summary>
        /// Блокування лоту на проді
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="livrea">Код одержувача лоту</param>
        /// <param name="dateTime">Дата створення запису</param>
        /// <remarks>
        /// Sample request:
        ///
        ///     http://qawms.avrora.lan/api/lot?key=exampleKey&amp;livrea=609
        ///
        /// </remarks>
        [HttpGet]
        public async Task<CrTempqaResponseModel> getTempqaModels([FromQuery]string key, [FromQuery]string livrea, [FromQuery]DateTime? dateTime)
        {
            string statusBlock = "block";

            CrTempqaResponseModel crTempqaResponseModel = await _WMSService.get(key, livrea, dateTime, statusBlock);

            return crTempqaResponseModel;
        }

        /// <summary>
        /// Розблокування лоту на проді
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="livrea">Код одержувача лоту</param>
        /// <param name="dateTime">Дата створення запису</param>
        /// <remarks>
        /// Sample request:
        ///
        ///     http://qawms.avrora.lan/api/lot/unlock?key=exampleKey&amp;livrea=609
        ///
        /// </remarks>
        [HttpGet("unlock")]
        public async Task<CrTempqaResponseModel> getTempqaModelsToUnlock([FromQuery] string key, [FromQuery] string livrea, [FromQuery] DateTime? dateTime)
        {
            string statusBlock = "unlock";

            CrTempqaResponseModel crTempqaResponseModel = await _WMSService.get(key, livrea, dateTime, statusBlock);

            return crTempqaResponseModel;
        }
    }
}
