using DevPartnersRainfall.Models;

namespace DevPartnersRainfall.ServiceResponder
{
    /// <summary>
    /// Generic reponse class wrapper
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ServiceResponse<T>
    {
        /// <summary>
        /// Data returned
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// Check for success execution
        /// </summary>
        public bool Success { get; set; } = true;
        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; } = null!;
        /// <summary>
        /// Error thrown
        /// </summary>
        public string Error { get; set; } = null!;
        /// <summary>
        /// Error trace
        /// </summary>
        public ErrorModel ErrMessages { get; set; } = null!;
    }
}
