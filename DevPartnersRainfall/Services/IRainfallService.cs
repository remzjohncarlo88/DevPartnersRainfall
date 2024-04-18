using DevPartnersRainfall.Models;

namespace DevPartnersRainfall.Services
{
    /// <summary>
    /// Rainfall Service Interface
    /// </summary>
    public interface IRainfallService
    {
        /// <summary>
        /// Get Rainfall readings by Id
        /// </summary>
        /// <param name="request">rainfall request params</param>
        /// <returns>List of Rainfall reading data</returns>
        List<RainfallReadingModel> GetRainfallById(RequestModel request);
    }
}
