﻿using System.ComponentModel.DataAnnotations;

namespace VillaBookingAPI.Models.Dto
{
    public class VillaDTO : IVillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Occupancy { get; set; }
        public int Sqrt { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
    }
}
