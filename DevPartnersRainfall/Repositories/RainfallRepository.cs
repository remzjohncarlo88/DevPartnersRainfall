using DevPartnersRainfall.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
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
        public async Task<List<RainfallReadingModel>> GetRainfallById(RequestModel request)
        {
            RainfallReadingResponseModel rainfallList = new();

            using (var httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat("http://environment.data.gov.uk/flood-monitoring/id/stations/", request.StationId, "/readings?_sorted&_limit=", request.Count)))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string apiResponse = (string)await response.Content.ReadAsStringAsync();
                        var _rainfallList = JsonConvert.DeserializeObject<RainfallReadingResponseModel>(apiResponse);

                        rainfallList = _rainfallList ?? new RainfallReadingResponseModel();
                    }
                }
            }

            return rainfallList.Items;
        }
    }
}
