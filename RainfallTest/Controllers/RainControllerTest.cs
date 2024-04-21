using DevPartnersRainfall.Controllers;
using DevPartnersRainfall.DTO;
using DevPartnersRainfall.Models;
using DevPartnersRainfall.ServiceResponder;
using DevPartnersRainfall.Services;
using Microsoft.AspNetCore.Mvc;
using RainfallTest.Services;
using Xunit;

namespace RainfallTest.Controllers
{
    public class RainControllerTest
    {
        private readonly RainfallController _controller;
        private readonly IRainfallService _service;

        /// <summary>
        /// FID Contoller Test
        /// </summary>
        public RainControllerTest()
        {
            _service = new RainServiceTest();
            _controller = new RainfallController(_service);
        }

        /// <summary>
        /// Check if the items returned are correct
        /// </summary>
        [Fact]
        public void GetDelayedFlights_WhenCalled_ReturnsRightItem()
        {
            RequestModel request = new RequestModel();
            request.StationId = "36805640646464";
            request.Count = 11;
            // Act
            var items = _controller.GetRainfallReadingsById(request) as OkObjectResult;
            // Assert
            var itemsEq = Assert.IsType<ServiceResponse<List<RainfallReadingDto>>>(items.Value);
            Assert.Equal(11, itemsEq.Data.Count);
        }

        // not found
    }
}
