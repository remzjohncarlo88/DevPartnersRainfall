using System.Runtime.Serialization;

namespace DevPartnersRainfall.Models
{
    /// <summary>
    /// Rain Item Model class
    /// </summary>
    [DataContract(Name = "RainfallReading")]
    public class RainfallReadingModel
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
