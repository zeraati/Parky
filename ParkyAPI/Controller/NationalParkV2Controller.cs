using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkyAPI.Model.Dto;
using ParkyAPI.Model.Mapper;
using ParkyAPI.Repository.IRepositories;

namespace ParkyAPI.Controller
{
    [Route("api/v{version:apiVersion}/nationalPark")]
    [ApiVersion("2.0")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "ParkyOpenAPISpecNationalPark")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class NationalParkV2Controller : ControllerBase
    {
        private readonly INationalParkRepository _nationalParkRepository;

        public NationalParkV2Controller(INationalParkRepository nationalParkRepository)
        {
            _nationalParkRepository = nationalParkRepository;
        }

        /// <summary>
        /// Get list of national parks.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<NationalParkDto>))]
        public IActionResult GetNationalParks()
        {
            var nationalParksDto = _nationalParkRepository.GetNationalParks()
                .Select(NationalParkMapper.Map).ToList();

            return Ok(nationalParksDto);
        }
    }
}
