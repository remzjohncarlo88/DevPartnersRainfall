using System.Runtime.Serialization;

namespace DevPartnersRainfall.Models
{
    /// <summary>
    /// Details of a rainfall reading
    /// </summary>
    [DataContract(Name = "RainfallReading")]
    public class RainfallReadingModel
    {
        /// <summary>
        /// Measured
        /// </summary>
        [DataMember(Name = "@id")]
        public string Id { get; set; } = null!;

        DateTime _date;
        /// <summary>
        /// Date
        /// </summary>
        [DataMember(Name = "dateTime")]
        public DateTime DateMeasured
        {
            get { return _date; }
            set { _date = Convert.ToDateTime(value); }
        }

        /// <summary>
        /// Value
        /// </summary>
        [DataMember(Name = "value")]
        public decimal AmountMeasured { get; set; }
    }
}
