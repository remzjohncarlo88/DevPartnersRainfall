using System.ComponentModel;

namespace DevPartnersRainfall.Models
{
    /// <summary>
    /// Responses model class
    /// </summary>
    public class ResponsesModel
    {
        /// <summary>
        /// Rainfall Reading Response model object
        /// </summary>
        public RainfallReadingResponseModel? RainfallReadingResponse { get; set; }
        /// <summary>
        /// Error Response model object
        /// </summary>
        public ErrorModel? ErrorResponse { get; set; }
    }
}
