using ParkyAPI.Model.Dto;
using ParkyAPI.Model.Entity;

namespace ParkyAPI.Model.Mapper
{
    public class TrailMapper
    {
        public static Trail Map(TrailDto dto)
        {
            return new Trail
            {
                Id = dto.Id,
                Name = dto.Name,
                Distance = dto.Distance,
                Difficulty = dto.Difficulty,
                Elevation = dto.Elevation,
                NationalParkId = dto.NationalParkId,
                DateCreated=dto.DateCreated
            };
        }

        public static TrailDto Map(Trail model)
        {
            return new TrailDto
            {
                Id = model.Id,
                Name = model.Name,
                Distance = model.Distance,
                Difficulty = model.Difficulty,
                Elevation = model.Elevation,
                NationalParkId = model.NationalParkId,
                NationalPark=NationalParkMapper.Map(model.NationalPark),
                DateCreated = model.DateCreated
            };
        }

        public static void Map(TrailDto dto, Trail model)
        {
            model.Id = dto.Id;
            model.Name = dto.Name;
            model.Distance = dto.Distance;
            model.Difficulty = dto.Difficulty;
            model.Elevation = dto.Elevation;
            model.NationalParkId = dto.NationalParkId;
            model.DateCreated = dto.DateCreated;
        }
    }
}
