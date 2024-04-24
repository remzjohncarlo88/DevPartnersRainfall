using AutoMapper;
using DevPartnersRainfall.Models;

namespace DevPartnersRainfall.DTO
{
    /// <summary>
    /// Auto Mapping
    /// </summary>
    public class DTOMapping : Profile
    {
        /// <summary>
        /// DTO Mapper
        /// </summary>
        public DTOMapping()
        {
            CreateMap<RainfallReadingModel, RainfallReadingDto>().ReverseMap();
            CreateMap<RainfallReadingResponseModel, RainfallReadingResponseDto>().ReverseMap();
        }        
    }
}
