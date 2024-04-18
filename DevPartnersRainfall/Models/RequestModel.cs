using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DevPartnersRainfall.Models
{
    /// <summary>
    /// Request Model class
    /// </summary>
    [DataContract]
    public class RequestModel
    {
        /// <summary>
        /// Rainfall Id
        /// </summary>
        [Description("The id of the reading station")]
        [Required]
        public string? stationId { get; set; }
        /// <summary>
        /// Display Count
        /// </summary>
        [Description("The number of readings to return")]
        [MinLength(1)]
        [MaxLength(100)]
        [DefaultValue(10)]
        public string? count { get; set; }
    }
}
