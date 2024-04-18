using Newtonsoft.Json;
using DevPartnersRainfall.Models;
using System.Net;

namespace DevPartnersRainfall.Repositories
{
    /// <summary>
    /// Rainfall Repository class
    /// </summary>
    public class RainfallRepository : IRainfallRepository
    {
        /// <summary>
        /// Retrieves the rainfall reading data using stationID and limiting it by user defined value.
        /// </summary>
        /// <param name="request">rainfall request arguments</param>
        /// <returns>List of rainfall readings</returns>
        public async Task<IEnumerable<RainItemModel>> GetRainfallById(RequestModel request)
        {
            RainModel rainfallList = new RainModel();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(string.Concat("http://environment.data.gov.uk/flood-monitoring/id/stations/", request.Id, "/readings?_sorted&_limit=", request.Limit)))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        rainfallList = JsonConvert.DeserializeObject<RainModel>(apiResponse);
                    }
                }
            }

            return rainfallList.Items;
        }
    }
}
