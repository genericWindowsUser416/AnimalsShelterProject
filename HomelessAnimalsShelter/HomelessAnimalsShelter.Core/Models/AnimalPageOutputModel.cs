﻿using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.Core.Models
{
    public class AnimalPageOutputModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public List<TagDto> TagDtos { get; set; } = new List<TagDto>();
    }
}

