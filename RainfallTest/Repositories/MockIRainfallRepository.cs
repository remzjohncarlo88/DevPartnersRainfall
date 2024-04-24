using DevPartnersRainfall.Models;
using DevPartnersRainfall.Repositories;
using Moq;

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
            var rainsEmpty = new List<RainfallReadingModel>();
            var rains = new List<RainfallReadingModel>()
            {
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T12:00:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.4) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(4.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(6.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.8) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(7.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(9.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T11:45:00Z"),
                        AmountMeasured = Convert.ToDecimal(20.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T12:00:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T12:00:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) },
                new RainfallReadingModel() { Id = "http://environment.data.gov.uk/flood-monitoring/data/readings/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm/2024-04-21T23-30-00Z",
                        Measure = "http://environment.data.gov.uk/flood-monitoring/id/measures/3680-rainfall-tipping_bucket_raingauge-t-15_min-mm",
                        DateMeasured = Convert.ToDateTime("2024-01-11T12:00:00Z"),
                        AmountMeasured = Convert.ToDecimal(1.1) }
            };

            mock.Setup(m => m.GetRainfallById(request))
                .Returns(Task.FromResult(rains.Where(x => x.Id.Contains(request.StationId)).Take(request.Count).ToList()));

            return mock;
        }
    }
}
