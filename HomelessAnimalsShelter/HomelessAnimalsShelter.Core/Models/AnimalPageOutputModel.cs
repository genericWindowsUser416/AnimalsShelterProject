﻿namespace HomelessAnimalsShelter.Core.Models
{
    public class AnimalPageOutputModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<string> TagList { get; set; } = new List<string>();
    }
}

