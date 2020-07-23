using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkyAPI.Models.Dto;
using ParkyAPI.Models.Mapper;
using ParkyAPI.Repositories.IRepositories;

namespace ParkyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalParkController : ControllerBase
    {
        private readonly INationalParkRepository _nationalParkRepository;

        public NationalParkController(INationalParkRepository nationalParkRepository)
        {
            _nationalParkRepository = nationalParkRepository;
        }

        [HttpGet("{nationalParkId:int}")]
        public IActionResult GetNationalPark(int nationalParkId)
        {
            var nationalPark = _nationalParkRepository.GetNationalPark(nationalParkId);

            if (nationalPark is null) return NotFound();

            var map = NationalParkMapper.Map(nationalPark);
            return Ok(map);
        }

        [HttpGet]
        public IActionResult GetNationalParks()
        {
            var nationalParks = _nationalParkRepository.GetNationalParks()
                .Select(NationalParkMapper.Map).ToList();

            return Ok(nationalParks);
        }
    }
}
