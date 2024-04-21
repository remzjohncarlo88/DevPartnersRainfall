using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevPartnersRainfall.Controllers;
using DevPartnersRainfall.Models;
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

        [Fact]
        public void GetDelayedFlights_WhenCalled_ReturnsRightItem()
        {
            RequestModel request = new RequestModel();
            request.StationId = "3680";
            request.Count = 11;
            // Act
            var items = _controller.GetRainfallReadingsById(request) as OkObjectResult;
            // Assert
            var itemsEq = Assert.IsType<List<RainfallReadingModel>>(items.Value);
            Assert.Equal(11, itemsEq.Count);
        }
    }
}
