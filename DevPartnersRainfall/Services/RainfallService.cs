using AutoMapper;
using DevPartnersRainfall.DTO;
using DevPartnersRainfall.Models;
using DevPartnersRainfall.Repositories;
using DevPartnersRainfall.ServiceResponder;

namespace DevPartnersRainfall.Services
{
    /// <summary>
    /// Rainfall Service class
    /// </summary>
    public class RainfallService : IRainfallService
    {
        private readonly IRainfallRepository _rainfallRepo;
        private readonly IMapper _mapper;

        /// <summary>
        /// Rainfall Service constructor - Constructor Injection
        /// </summary>
        /// <param name="rainfallRepo">rainfall repository object</param>
        /// <param name="mapper">mapper object</param>
        public RainfallService(IRainfallRepository rainfallRepo, IMapper mapper)
        {
            this._rainfallRepo = rainfallRepo;
            this._mapper = mapper;
        }

        /// <summary>
        /// Get Rainfall readings by Id
        /// </summary>
        /// <param name="request">rainfall request params</param>
        /// <returns>List of Rainfall reading data</returns>
        public ServiceResponse<List<RainfallReadingDto>> GetRainfallById(RequestModel request)
        {
            ServiceResponse<List<RainfallReadingDto>> _response = new();

            try
            {
                var _items = _rainfallRepo.GetRainfallById(request).Result.ToList();

                if (_items == null)
                {
                    _response.Success = false;
                    _response.Message = "NotFound";
                    return _response;
                }

                var _rainfallReadingDto = new List<RainfallReadingDto>();

                foreach (var item in _items)
                {
                    _rainfallReadingDto.Add(_mapper.Map<RainfallReadingDto>(item));
                }

                _response.Success = true;
                _response.Message = "ok";
                _response.Data = _rainfallReadingDto;
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Data = null;
                _response.Message = "Error";
                _response.ErrorMessages = new List<string> { Convert.ToString(ex.Message) };
            }

            return _response;
        }
    }
}
