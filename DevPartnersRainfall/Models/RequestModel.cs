using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevPartnersRainfall.Models
{
    /// <summary>
    /// Request Model class
    /// </summary>
    public class RequestModel
    {
        /// <summary>
        /// Rainfall Id
        /// </summary>
        [Description("Rainfall Id")]
        public string? Id { get; set; }
        /// <summary>
        /// Display Count
        /// </summary>
        [DefaultValue(10), MinLength(1), MaxLength(100), Required, Description("The number of readings to return")]
        public int Limit { get; set; }
    }
}
