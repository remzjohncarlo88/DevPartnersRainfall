using Microsoft.AspNetCore.Mvc;
using DevPartnersRainfall.Models;
using DevPartnersRainfall.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace DevPartnersRainfall.Controllers
{
    /// <summary>
    /// Rainfall Controller class
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class RainfallController : ControllerBase
    {
        private readonly IRainfallService _rainfallService;

        /// <summary>
        /// Rainfall constructor
        /// </summary>
        /// <param name="rainfallService">Rainfall Service object injection</param>
        public RainfallController(IRainfallService rainfallService)
        {
            _rainfallService = rainfallService;
        }

        /// <summary>
        /// Gets the list of UK's rainfall readings
        /// </summary>
        /// <param name="id">Station ID</param>
        /// <param name="limit">Filter Items by INT Limit</param>
        /// <returns></returns>
        [HttpGet(Name = "GetRainfallReadingsById")]
        [Produces("application/json")]
        [SwaggerOperation(Summary = "Get the Rainfall reading data by station id.")]
        [SwaggerResponse(200, "A list of rainfall readings successfully retrieved", typeof(RainItemModel))]        
        [SwaggerResponse(400, "Invalid request")]
        [SwaggerResponse(404, "No readings found for the specified stationId")]
        [SwaggerResponse(500, "Internal Server Error")]
        public IActionResult GetRainfallReadingsById(string id, int limit)
        {
            RequestModel request = new RequestModel
            {
                Id = id,
                Limit = limit
            };

            var rainfallList = _rainfallService.GetRainfallById(request);

            if (rainfallList.Equals(null))
                return NotFound();

            return Ok(rainfallList);
        }
    }
}
