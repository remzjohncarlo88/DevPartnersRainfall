using DevPartnersRainfall.Models;
using System.Runtime.Serialization;

namespace DevPartnersRainfall.DTO
{
    /// <summary>
    /// Rainfall Reading Response DTO
    /// </summary>
    public class RainfallReadingResponseDto
    {
        /// <summary>
        /// List of rain readings
        /// </summary>
        [DataMember(Name = "items")]
        public List<RainfallReadingModel> Items { get; set; }
    }
}
