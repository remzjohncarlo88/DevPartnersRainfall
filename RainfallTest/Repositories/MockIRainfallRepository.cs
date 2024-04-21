using DevPartnersRainfall.DTO;
using DevPartnersRainfall.Models;
using DevPartnersRainfall.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RainfallTest.Repositories
{
    /// <summary>
    /// MockIRainfallRepository
    /// </summary>
    public class MockIRainfallRepository
    {
        /// <summary>
        /// GetGetRainfallByIdMock
        /// </summary>
        /// <param name="request">request object</param>
        /// <returns></returns>
        public static Mock<IRainfallRepository> GetMockIRainfallRepository(RequestModel request)
        {
            var mock = new Mock<IRainfallRepository>();
            var rains = new List<RainfallReadingModel>()
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
                        AmountMeasured = Convert.ToDecimal(20.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T12:00:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T12:00:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { DateMeasured = Convert.ToDateTime("2024-01-11T12:00:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) }
            };

            mock.Setup(m => m.GetRainfallById(request)).Returns(Task.FromResult(rains.Take(request.Count).ToList()));

            return mock;
        }
    }
}
