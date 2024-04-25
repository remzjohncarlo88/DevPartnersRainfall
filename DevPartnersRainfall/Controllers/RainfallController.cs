using DevPartnersRainfall.DTO;
using DevPartnersRainfall.Models;
using DevPartnersRainfall.ServiceResponder;
using DevPartnersRainfall.Services;
using Microsoft.AspNetCore.Mvc;
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
        /// Get rainfall readings by station Id
        /// </summary>
        /// <param name="request">request containing station ID and limit filter number</param>
        /// <returns>List of rainfall readings</returns>
        [HttpGet(Name = "GetRainfallReadingsById")]
        [Produces("application/json")]
        [SwaggerOperation(OperationId = "get-rainfall", Description = "Retrieve the latest readings for the specified stationId", Summary = "Get the Rainfall reading data by station id")]
        [SwaggerResponse(200, "A list of rainfall readings successfully retrieved", typeof(RainfallReadingResponseModel))]
        [SwaggerResponse(400, "Invalid request", typeof(ErrorModel))]
        [SwaggerResponse(404, "No readings found for the specified stationId", typeof(ErrorModel))]
        [SwaggerResponse(500, "Internal Server Error", typeof(ErrorModel))]
        public IActionResult GetRainfallReadingsById([FromQuery] RequestModel request)
        {
            ServiceResponse<List<RainfallReadingDto>> rain;

            // 400
            if (request.Count > 0)
            {
                ErrorModel err = new();
                List<ErrorDetailModel> errList = new();

                err.Message = "The request is malformed.";

                if (request.Count < 1 || request.Count > 100)
                {                    
                    errList.Add(new ErrorDetailModel("Count", "Value not allowed."));
                    err.Items = errList;                    
                }

                if (string.IsNullOrEmpty(request.StationId))
                {
                    errList.Add(new ErrorDetailModel("StationId", "Station Id is required."));
                    err.Items = errList;

                }

                if (errList.Count > 0)
                    return BadRequest(err);
            }
            
            rain = _rainfallService.GetRainfallById(request);

            // 404
            if (!rain.Success & rain.Data == null)
            {
                return NotFound(rain.ErrMessages);
            }

            // 500
            if (!rain.Success & rain.Message.Equals("Error"))
            {
                return StatusCode(500, rain.ErrMessages);
            }

            return Ok(rain.Data);
        }
    }
}
