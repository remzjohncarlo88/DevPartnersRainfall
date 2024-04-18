using DevPartnersRainfall.Models;
using DevPartnersRainfall.Repositories;

namespace DevPartnersRainfall.Services
{
    /// <summary>
    /// Rainfall Service class
    /// </summary>
    public class RainfallService : IRainfallService
    {
        private readonly IRainfallRepository _rainfallRepo;

        /// <summary>
        /// Rainfall Service constructor - Constructor Injection
        /// </summary>
        /// <param name="rainfallRepo">rainfall repository object</param>
        public RainfallService(IRainfallRepository rainfallRepo)
        {
            _rainfallRepo = rainfallRepo;
        }

        /// <summary>
        /// Get Rainfall readings by Id
        /// </summary>
        /// <param name="request">rainfall request params</param>
        /// <returns>List of Rainfall reading data</returns>
        public List<RainItemModel> GetRainfallById(RequestModel request)
        {
            List<RainItemModel> rainItems = _rainfallRepo.GetRainfallById(request).Result.ToList();

            return rainItems;
        }
    }
}
