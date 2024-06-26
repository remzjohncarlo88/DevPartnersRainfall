﻿using System.ComponentModel;
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
        /// The id of the reading station
        /// </summary>
        [Description("The id of the reading station")]
        [Required]
        public string StationId { get; set; } = null!;
        /// <summary>
        /// The number of readings to return
        /// </summary>
        [Description("The number of readings to return")]
        [DefaultValue(10)]
        [Range(1, 100)]
        public int Count { get; set; }
    }
}
