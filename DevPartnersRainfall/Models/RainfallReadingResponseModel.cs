using System.Runtime.Serialization;

namespace DevPartnersRainfall.Models
{
    /// <summary>
    /// Rainfall Model class
    /// </summary>
    [DataContract(Name = "RainfallReadingResponse")]
    public class RainfallReadingResponseModel
    {
        /// <summary>
        /// List of rain readings
        /// </summary>
        [DataMember(Name = "items")]
        public List<RainfallReadingModel>? Items { get; set; }
    }
}
