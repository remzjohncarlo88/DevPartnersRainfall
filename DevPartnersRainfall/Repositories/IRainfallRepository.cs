using DevPartnersRainfall.Models;
using System.Collections;

namespace DevPartnersRainfall.Repositories
{
    /// <summary>
    /// Rainfall Repository Inteface
    /// </summary>
    public interface IRainfallRepository
    {
        /// <summary>
        /// Retrieves the rainfall reading data using stationID and limiting it by user defined value.
        /// </summary>
        /// <param name="request">rainfall request arguments</param>
        /// <returns>List of rainfall readings</returns>
        Task<List<RainfallReadingModel>> GetRainfallById(RequestModel request);
    }
}
