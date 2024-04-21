using System.Runtime.Serialization;

namespace DevPartnersRainfall.DTO
{
    /// <summary>
    /// Rainfall Reading DTO
    /// </summary>
    public class RainfallReadingDto
    {
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
