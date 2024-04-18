using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevPartnersRainfall.Models;
using DevPartnersRainfall.Services;

namespace RainfallTest.Services
{
    public class RainServiceTest : IRainfallService
    {
        private readonly List<RainfallReadingModel> _rainItems;
        public RainServiceTest()
        {
            _rainItems = new List<RainfallReadingModel>()
            {
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T12:00:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.4) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(4.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(6.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.8) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(7.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(9.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(20.1) }
            };
        }

        /// <summary>
        /// GetRainfallById
        /// </summary>
        /// <param name="request">rainfall params</param>
        /// <returns>Rainfall list</returns>
        public List<RainfallReadingModel> GetRainfallById(RequestModel request)
        {
            return _rainItems.Take(Convert.ToInt32(request.Count)).ToList();
        }
    }
}
