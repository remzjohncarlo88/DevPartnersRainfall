﻿using DevPartnersRainfall.Controllers;
using DevPartnersRainfall.DTO;
using DevPartnersRainfall.Models;
using DevPartnersRainfall.Services;
using Microsoft.AspNetCore.Http;
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
        public void GetCorrectStationID_WhenCalled_ReturnsRightItem()
        {
            var request = new RequestModel
            {
                StationId = "3680",
                Count = 11
            };
            // Act
            var results = (OkObjectResult)_controller.GetRainfallReadingsById(request);
            // Assert
            var itemsEq = Assert.IsType<List<RainfallReadingDto>>(results.Value);
            Assert.Equal(11, itemsEq.Count);
        }

        /// <summary>
        /// Check if it will return empty data for Incorrect Station Id
        /// </summary>
        [Fact]
        public void GetIncorrectStationID_WhenCalled_ReturnsEmpty()
        {
            var request = new RequestModel
            {
                StationId = "368054015465606548",
                Count = 11
            };
            // Act
            var results = (ObjectResult)_controller.GetRainfallReadingsById(request);
            // Assert
            Assert.Equal(StatusCodes.Status404NotFound, results.StatusCode);
        }

        /// <summary>
        /// Check if it will return empty data for Empty Station Id
        /// </summary>
        [Fact]
        public void GetEmptyStationID_WhenCalled_ReturnsEmpty()
        {
            var request = new RequestModel
            {
                StationId = "",
                Count = 11
            };
            // Act
            var results = (ObjectResult)_controller.GetRainfallReadingsById(request);
            // Assert
            Assert.Equal(StatusCodes.Status400BadRequest, results.StatusCode);
        }
    }
}
