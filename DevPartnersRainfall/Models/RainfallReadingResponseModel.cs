using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace DevPartnersRainfall.Models
{
    /// <summary>
    /// Details of a rainfall reading
    /// </summary>
    [DataContract(Name = "RainfallReadingResponse")]
    public class RainfallReadingResponseModel
    {
        /// <summary>
        /// List of rain readings
        /// </summary>
        [DataMember(Name = "items")]
        public List<RainfallReadingModel> Items { get; set; } = [];
    }
}
