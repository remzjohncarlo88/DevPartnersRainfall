using AutoMapper;
using DevPartnersRainfall.Controllers;
using DevPartnersRainfall.DTO;
using DevPartnersRainfall.Models;
using DevPartnersRainfall.Repositories;
using DevPartnersRainfall.ServiceResponder;
using DevPartnersRainfall.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RainfallTest.Repositories;

namespace RainfallTest.Services
{
    public class RainServiceTest : IRainfallService
    {
        /// <summary>
        /// GetMapper
        /// </summary>
        /// <returns></returns>
        public IMapper GetMapper()
        {
            var mappingProfile = new DTOMapping();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(mappingProfile));
            return new Mapper(configuration);
        }

        /// <summary>
        /// GetRainfallById
        /// </summary>
        /// <param name="request">rainfall params</param>
        /// <returns>Rainfall list</returns>
        public ServiceResponse<List<RainfallReadingDto>> GetRainfallById(RequestModel request)
        {
            var repositoryMock = MockIRainfallRepository.GetMockIRainfallRepository(request);
            var mapper = GetMapper();
            var ownerController = new RainfallService(repositoryMock.Object, mapper);
            var result = ownerController.GetRainfallById(request);

            return result;
        }
    }
}
