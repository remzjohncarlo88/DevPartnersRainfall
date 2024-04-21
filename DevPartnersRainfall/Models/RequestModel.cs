using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace DevPartnersRainfall.Models
{
    /// <summary>
    /// Request Model class
    /// </summary>
    [DataContract(Name = "Request")]
    public class RequestModel
    {
        /// <summary>
        /// Rainfall Id
        /// </summary>
        [Description("The id of the reading station")]
        [Required]
        public string? StationId { get; set; }
        private int limit;
        /// <summary>
        /// Display Count
        /// </summary>
        [Description("The number of readings to return")]
        [DefaultValue(10)]
        public int Count {
            get
            {
                return limit;
            }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(Count));
                }

                limit = value;
            }
        }
    }
}
