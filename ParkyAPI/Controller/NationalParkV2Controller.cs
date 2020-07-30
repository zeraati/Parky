using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkyAPI.Model.Dto;
using ParkyAPI.Model.Mapper;
using ParkyAPI.Repository.IRepositories;

namespace ParkyAPI.Controller
{
    [Route("api/nationalPark")]
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
        /// Get individual national park
        /// </summary>
        /// <param name="nationalParkId"> The Id of the national Park </param>
        /// <returns></returns>
        [HttpGet("{nationalParkId:int}", Name = "GetNationalPark")]
        [ProducesResponseType(200, Type = typeof(NationalParkDto))]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public IActionResult GetNationalPark(int nationalParkId)
        {
            var nationalPark = _nationalParkRepository.GetNationalPark(nationalParkId);

            if (nationalPark is null) return NotFound();

            var nationalParkDto = NationalParkMapper.Map(nationalPark);
            return Ok(nationalParkDto);
        }
    }
}
