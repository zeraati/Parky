using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkyAPI.Models.Dto;

namespace ParkyAPI.Models.Mapper
{
    public class NationalParkMapper
    {
        public static NationalPark Map(NationalParkDto dto)
        {
            return new NationalPark
            {
                Id = dto.Id,
                Name = dto.Name,
                State = dto.State,
                Created = dto.Created,
                Picture = dto.Picture,
                Established = dto.Established
            };
        }

        public static NationalParkDto Map(NationalPark model)
        {
            return new NationalParkDto
            {
                Id = model.Id,
                Name = model.Name,
                State = model.State,
                Created = model.Created,
                Picture = model.Picture,
                Established = model.Established
            };
        }

        public static void Map(NationalParkDto dto, NationalPark model)
        {
            model.Id = dto.Id;
            model.Name = dto.Name;
            model.State = dto.State;
            model.Created = dto.Created;
            model.Picture = dto.Picture;
            model.Established = dto.Established;
        }
    }
}
