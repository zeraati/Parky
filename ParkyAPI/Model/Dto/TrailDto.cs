﻿using System.ComponentModel.DataAnnotations;
using ParkyAPI.Model.Entity;

namespace ParkyAPI.Model.Dto
{
    public class TrailDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Distance { get; set; }

        public Trail.DifficultyType Difficulty { get; set; }

        [Required]
        public int NationalParkId { get; set; }

        public NationalParkDto NationalPark { get; set; }

        [Required]
        public double Elevation { get; set; }
    }
}
