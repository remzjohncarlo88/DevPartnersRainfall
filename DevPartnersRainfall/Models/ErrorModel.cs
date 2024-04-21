namespace DevPartnersRainfall.Models
{
    /// <summary>
    /// Error model class
    /// </summary>
    public class ErrorModel
    {
        /// <summary>
        /// Message
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// Detail
        /// </summary>
        public List<string>? Detail { get; set; }
        /// <summary>
        /// List of errors
        /// </summary>
        public List<ErrorDetailModel> Items { get; set; }
    }
}
